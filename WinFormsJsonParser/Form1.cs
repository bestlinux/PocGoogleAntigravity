using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;
using Microsoft.Data.Sqlite;

namespace WinFormsJsonParser
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient = new();
        private string _parsedTeamAName = "Time A";
        private string _parsedTeamBName = "Time B";

        private readonly string _dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bets.db");
        private MatchAnalysis? _lastMatchAnalysis = null;

        // Cores do tema para hover
        private readonly Color _colorBlue = Color.FromArgb(37, 99, 235);
        private readonly Color _colorBlueHover = Color.FromArgb(59, 130, 246);

        private readonly Color _colorGrey = Color.FromArgb(75, 85, 99);
        private readonly Color _colorGreyHover = Color.FromArgb(107, 114, 128);

        private readonly Color _colorViolet = Color.FromArgb(139, 92, 246);
        private readonly Color _colorVioletHover = Color.FromArgb(167, 139, 250);

        private readonly Color _colorGreen = Color.FromArgb(16, 185, 129);
        private readonly Color _colorGreenHover = Color.FromArgb(52, 211, 153);

        public Form1()
        {
            InitializeComponent();
            SetupHttpClientHeaders();
            InitializeDatabase();
            StyleHistoryGrid();
            LoadHistoryGrid();
            StyleRealizedGrid();
            LoadRealizedGrid();
            SetupEventHandlers();
            SetupButtonAnimations();
            
            // Template para cadastro de Odds Realizadas
            txtRealizedInput.Text = "[CAMPEONATO] Libertadores\r\n" +
                                    "[JOGO] Fluminense vs Deportivo La Guaira\r\n" +
                                    "[DATA] 27/05/2026\r\n" +
                                    "[BET] Over 1.5: 37.90%\r\n" +
                                    "[ODD] 1,90\r\n" +
                                    "[VALOR] 10,00\r\n" +
                                    "[BET] Over 2.5: 13.90%\r\n" +
                                    "[ODD] 2,50\r\n" +
                                    "[VALOR] 20,00";
        }

        private void SetupHttpClientHeaders()
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36");
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json, text/plain, */*");
            _httpClient.DefaultRequestHeaders.Add("Accept-Language", "pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7");
            _httpClient.DefaultRequestHeaders.Add("Referer", "https://www.betano.bet.br/");
        }

        private void InitializeDatabase()
        {
            try
            {
                using (var connection = new SqliteConnection($"Data Source={_dbPath}"))
                {
                    connection.Open();
                    string createTableQuery = """
                        CREATE TABLE IF NOT EXISTS Bets (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Campeonato TEXT,
                            Jogo TEXT,
                            Data TEXT,
                            HistoricoGols TEXT,
                            DebugCalculo TEXT,
                            Probabilidades TEXT,
                            Qualificados TEXT,
                            ResumoLesoes TEXT,
                            Raciocinio TEXT,
                            DataRegistro TEXT
                        );
                        CREATE TABLE IF NOT EXISTS RealizedOdds (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Campeonato TEXT,
                            Jogo TEXT,
                            Data TEXT,
                            Bet TEXT,
                            Valor REAL,
                            ValorApostado REAL,
                            Status TEXT,
                            DataRegistro TEXT
                        );
                        """;
                    using (var command = new SqliteCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inicializar o banco de dados SQLite:\n{ex.Message}", "Erro de Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StyleHistoryGrid()
        {
            dgvHistory.EnableHeadersVisualStyles = false;
            dgvHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 23, 42);
            dgvHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(56, 189, 248);
            dgvHistory.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgvHistory.DefaultCellStyle.BackColor = Color.FromArgb(39, 39, 42);
            dgvHistory.DefaultCellStyle.ForeColor = Color.White;
            dgvHistory.DefaultCellStyle.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dgvHistory.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvHistory.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);

            dgvHistory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(28, 28, 30);
            dgvHistory.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            dgvHistory.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dgvHistory.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;

            dgvHistory.RowHeadersVisible = false;
            dgvHistory.GridColor = Color.FromArgb(63, 63, 70);
            dgvHistory.BorderStyle = BorderStyle.None;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.MultiSelect = false;
            dgvHistory.ReadOnly = true;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadHistoryGrid()
        {
            try
            {
                var dt = new System.Data.DataTable();
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("Campeonato", typeof(string));
                dt.Columns.Add("Jogo", typeof(string));
                dt.Columns.Add("Data", typeof(string));
                dt.Columns.Add("Data Registro", typeof(string));

                using (var connection = new SqliteConnection($"Data Source={_dbPath}"))
                {
                    connection.Open();
                    string selectQuery = "SELECT Id, Campeonato, Jogo, Data, DataRegistro FROM Bets ORDER BY Id DESC";
                    using (var command = new SqliteCommand(selectQuery, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dt.Rows.Add(
                                    reader.GetInt32(0),
                                    reader.IsDBNull(1) ? "" : reader.GetString(1),
                                    reader.IsDBNull(2) ? "" : reader.GetString(2),
                                    reader.IsDBNull(3) ? "" : reader.GetString(3),
                                    reader.IsDBNull(4) ? "" : reader.GetString(4)
                                );
                            }
                        }
                    }
                }

                dgvHistory.DataSource = dt;

                var colId = dgvHistory.Columns["Id"];
                if (colId != null)
                {
                    colId.Visible = false; // Oculta o ID da visualização do grid
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar o histórico de apostas:\n{ex.Message}", "Erro de Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupEventHandlers()
        {
            // Aba 1 - Mapeador de Estatísticas
            btnCarregarUrl.Click += async (s, e) => await CarregarUrlAsync();
            btnCarregarExemplo.Click += CarregarExemplo;
            btnProcessarJson.Click += (s, e) => ProcessarJsonText();
            btnGerarProbabilidades.Click += GerarProbabilidades;

            // Aba 2 - Cálculo de ODDs
            btnCarregarExemploOdds.Click += CarregarExemploOdds;
            btnProcessarOdds.Click += ProcessarOdds;

            // Aba 3 - Analisa de Resultados
            btnCarregarExemploAnalise.Click += CarregarExemploAnalise;
            btnProcessarAnalise.Click += ProcessarAnalise;
            btnSalvarAnalise.Click += SalvarAnalise;

            // Aba 4 - Histórico de Apostas
            btnDeleteRecord.Click += ExcluirAposta;
            dgvHistory.SelectionChanged += DgvHistory_SelectionChanged;

            // Aba 5 - Odd's Realizadas
            btnSaveRealized.Click += SalvarRealizadas;
            btnDeleteRealized.Click += ExcluirRealizada;
            dgvRealized.CellDoubleClick += DgvRealized_CellDoubleClick;
            dgvRealized.CellFormatting += DgvRealized_CellFormatting;
            chkFilterDate.CheckedChanged += (s, e) => LoadRealizedGrid();
            dtpFilterDate.ValueChanged += (s, e) => {
                if (chkFilterDate.Checked) LoadRealizedGrid();
                else UpdateDayTotal();
            };

            // Renderização customizada das abas (Dark Theme)
            tabMain.DrawItem += TabMain_DrawItem;
        }

        private void SetupButtonAnimations()
        {
            // Aba 1
            AddHoverEffect(btnCarregarUrl, _colorBlue, _colorBlueHover);
            AddHoverEffect(btnCarregarExemplo, _colorGrey, _colorGreyHover);
            AddHoverEffect(btnProcessarJson, _colorViolet, _colorVioletHover);
            AddHoverEffect(btnGerarProbabilidades, _colorGreen, _colorGreenHover);

            // Aba 2
            AddHoverEffect(btnCarregarExemploOdds, _colorGrey, _colorGreyHover);
            AddHoverEffect(btnProcessarOdds, _colorViolet, _colorVioletHover);

            // Aba 3
            AddHoverEffect(btnCarregarExemploAnalise, _colorGrey, _colorGreyHover);
            AddHoverEffect(btnProcessarAnalise, _colorViolet, _colorVioletHover);
            AddHoverEffect(btnSalvarAnalise, _colorGreen, _colorGreenHover);

            // Aba 4
            AddHoverEffect(btnDeleteRecord, Color.FromArgb(239, 68, 68), Color.FromArgb(248, 113, 113));

            // Aba 5
            AddHoverEffect(btnSaveRealized, _colorGreen, _colorGreenHover);
            AddHoverEffect(btnDeleteRealized, Color.FromArgb(239, 68, 68), Color.FromArgb(248, 113, 113));
        }

        private void AddHoverEffect(Button btn, Color normalColor, Color hoverColor)
        {
            btn.BackColor = normalColor;
            btn.MouseEnter += (s, e) => btn.BackColor = hoverColor;
            btn.MouseLeave += (s, e) => btn.BackColor = normalColor;
        }

        private void TabMain_DrawItem(object? sender, DrawItemEventArgs e)
        {
            var tabCtrl = (TabControl)sender!;
            var page = tabCtrl.TabPages[e.Index];
            var tabRect = tabCtrl.GetTabRect(e.Index);

            // Fundo do cabeçalho da aba
            using (var bgBrush = new SolidBrush(Color.FromArgb(15, 23, 42)))
            {
                e.Graphics.FillRectangle(bgBrush, tabRect);
            }

            // Seleção de Cores baseado no foco da aba
            bool isActive = tabCtrl.SelectedIndex == e.Index;
            Color textColor = isActive ? Color.FromArgb(56, 189, 248) : Color.FromArgb(148, 163, 184);

            // Indicador azul na aba ativa
            if (isActive)
            {
                using (var activeBrush = new SolidBrush(Color.FromArgb(56, 189, 248)))
                {
                    e.Graphics.FillRectangle(activeBrush, tabRect.X, tabRect.Bottom - 4, tabRect.Width, 4);
                }
            }

            // Escrever texto centralizado
            TextRenderer.DrawText(e.Graphics, page.Text, this.Font, tabRect, textColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        #region Logica da Aba 1 (Mapeador de Estatísticas)

        private async Task CarregarUrlAsync()
        {
            string url = txtUrlJson.Text.Trim();
            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("Por favor, insira uma URL válida no campo [URL_JSON].", "URL Vazia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnCarregarUrl.Enabled = false;
                btnCarregarUrl.Text = "Carregando...";

                string responseBody;
                try
                {
                    responseBody = await FetchWithCurlAsync(url);
                }
                catch (Exception)
                {
                    responseBody = await _httpClient.GetStringAsync(url);
                }

                txtRawJson.Text = responseBody;
                ProcessarJsonText();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados da URL:\n{ex.Message}", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnCarregarUrl.Enabled = true;
                btnCarregarUrl.Text = "Carregar URL";
            }
        }

        private async Task<string> FetchWithCurlAsync(string url)
        {
            var startInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "curl.exe",
                Arguments = $"-s -H \"User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36\" -H \"Accept: application/json\" \"{url}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (var process = new System.Diagnostics.Process { StartInfo = startInfo })
            {
                process.Start();
                string output = await process.StandardOutput.ReadToEndAsync();
                string error = await process.StandardError.ReadToEndAsync();
                await process.WaitForExitAsync();

                if (process.ExitCode != 0)
                {
                    throw new Exception($"curl falhou com código de saída {process.ExitCode}. Erro: {error}");
                }

                if (string.IsNullOrWhiteSpace(output))
                {
                    throw new Exception("Nenhum data retornado pela ferramenta de busca.");
                }

                return output;
            }
        }

        private void CarregarExemplo(object? sender, EventArgs e)
        {
            string exemplo = """
                             {
                               "d": {
                                 "sportId": 1,
                                 "config": {
                                   "availableTabs": [
                                     "h2h",
                                     "standings",
                                     "overview",
                                     "playerStats"
                                   ],
                                   "dateTimeFormatConfig": {
                                     "shortDate": "DD/MM/YYYY",
                                     "shortTime": "HH:mm",
                                     "shortDateNoYear": "DD/MM"
                                   }
                                 },
                                 "teams": [
                                   {
                                     "id": 1904622,
                                     "name": "Bétis",
                                     "statistics": {
                                       "form": {
                                         "title": "Forma",
                                         "values": [
                                           {
                                             "value": "E",
                                             "type": 1
                                           },
                                           {
                                             "value": "V",
                                             "type": 0
                                           },
                                           {
                                             "value": "E",
                                             "type": 1
                                           },
                                           {
                                             "value": "V",
                                             "type": 0
                                           },
                                           {
                                             "value": "D",
                                             "type": 2
                                           }
                                         ]
                                       },
                                       "items": [
                                         {
                                           "title": "Média de Posse de Bola. ",
                                           "value": "49.6",
                                           "stat": 1,
                                           "highlight": true
                                         },
                                         {
                                           "title": "Jogos Disputados",
                                           "value": "37",
                                           "stat": 2,
                                           "highlight": false
                                         },
                                         {
                                           "title": "Total de Gols Marcados",
                                           "value": "57",
                                           "stat": 3,
                                           "highlight": true
                                         },
                                         {
                                           "title": "Média de Gols Marcados",
                                           "value": "1.5",
                                           "stat": 4,
                                           "highlight": true
                                         },
                                         {
                                           "title": "Média de Gols Sofridos",
                                           "value": "1.3",
                                           "stat": 5,
                                           "highlight": true
                                         },
                                         {
                                           "title": "xGoals",
                                           "value": "1.46",
                                           "stat": 6,
                                           "highlight": true,
                                           "information": "Gols esperados (xG) é usado para calcular o número de gols que deveriam ter sido marcados com base na qualidade das chances criadas."
                                         },
                                         {
                                           "title": "Média de Finalizações no Gol ",
                                           "value": "4.7",
                                           "stat": 7,
                                           "highlight": true
                                         },
                                         {
                                           "title": "Média de Finalizações",
                                           "value": "5.6",
                                           "stat": 8,
                                           "highlight": false
                                         },
                                         {
                                           "title": "Média de Escanteios",
                                           "value": "4.6",
                                           "stat": 9,
                                           "highlight": true
                                         },
                                         {
                                           "title": "Média de Cartões Amarelos",
                                           "value": "1.9",
                                           "stat": 10,
                                           "highlight": true
                                         },
                                         {
                                           "title": "Cartões Vermelhos",
                                           "value": "2",
                                           "stat": 11,
                                           "highlight": true
                                         },
                                         {
                                           "title": "Penalidades Concedidas",
                                           "value": "3",
                                           "stat": 12,
                                           "highlight": false
                                         },
                                         {
                                           "title": "Jogos sem sofrer gols",
                                           "value": "10",
                                           "stat": 13,
                                           "highlight": true
                                         },
                                         {
                                           "title": "Faltas",
                                           "value": "10.6",
                                           "stat": 14,
                                           "highlight": true
                                         }
                                       ]
                                     }
                                   },
                                   {
                                     "id": 109295,
                                     "name": "Levante",
                                     "statistics": {
                                       "form": {
                                         "title": "Forma",
                                         "values": [
                                           {
                                             "value": "E",
                                             "type": 1
                                           },
                                           {
                                             "value": "D",
                                             "type": 2
                                           },
                                           {
                                             "value": "V",
                                             "type": 0
                                           },
                                           {
                                             "value": "V",
                                             "type": 0
                                           },
                                           {
                                             "value": "V",
                                             "type": 0
                                           }
                                         ]
                                       },
                                       "items": [
                                         {
                                           "title": "Média de Posse de Bola. ",
                                           "value": "42.7",
                                           "stat": 1,
                                           "highlight": false
                                         },
                                         {
                                           "title": "Jogos Disputados",
                                           "value": "37",
                                           "stat": 2,
                                           "highlight": false
                                         },
                                         {
                                           "title": "Total de Gols Marcados",
                                           "value": "46",
                                           "stat": 3,
                                           "highlight": false
                                         },
                                         {
                                           "title": "Média de Gols Marcados",
                                           "value": "1.2",
                                           "stat": 4,
                                           "highlight": false
                                         },
                                         {
                                           "title": "Média de Gols Sofridos",
                                           "value": "1.6",
                                           "stat": 5,
                                           "highlight": false
                                         },
                                         {
                                           "title": "xGoals",
                                           "value": "1.35",
                                           "stat": 6,
                                           "highlight": false,
                                           "information": "Gols esperados (xG) é usado para calcular o número de gols que deveriam ter sido marcados com base na qualidade das chances criadas."
                                         },
                                         {
                                           "title": "Média de Finalizações no Gol ",
                                           "value": "3.8",
                                           "stat": 7,
                                           "highlight": false
                                         },
                                         {
                                           "title": "Média de Finalizações",
                                           "value": "4.9",
                                           "stat": 8,
                                           "highlight": true
                                         },
                                         {
                                           "title": "Média de Escanteios",
                                           "value": "4.2",
                                           "stat": 9,
                                           "highlight": false
                                         },
                                         {
                                           "title": "Média de Cartões Amarelos",
                                           "value": "2.2",
                                           "stat": 10,
                                           "highlight": false
                                         },
                                         {
                                           "title": "Cartões Vermelhos",
                                           "value": "5",
                                           "stat": 11,
                                           "highlight": false
                                         },
                                         {
                                           "title": "Penalidades Concedidas",
                                           "value": "6",
                                           "stat": 12,
                                           "highlight": true
                                         },
                                         {
                                           "title": "Jogos sem sofrer gols",
                                           "value": "9",
                                           "stat": 13,
                                           "highlight": false
                                         },
                                         {
                                           "title": "Faltas",
                                           "value": "12.4",
                                           "stat": 14,
                                           "highlight": false
                                         }
                                       ]
                                     }
                                   }
                                 ],
                                 "startTime": "2026-05-23T19:00:00Z",
                                 "league": {
                                   "id": 5,
                                   "name": "LaLiga"
                                 },
                                 "insights": [
                                   {
                                     "text": "Real Betis: marcou 3 ou mais gols em cada um dos últimos 4 jogos ",
                                     "locale": "pt-br",
                                     "marketTypes": [
                                       {
                                         "specifierTypeId": 2,
                                         "specifierValue": 2.5,
                                         "id": 13,
                                         "name": ""
                                       }
                                     ]
                                   },
                                   {
                                     "text": "Real Betis: Houve um gol no primeiro tempo em cada um dos ultimos 9 jogos",
                                     "locale": "pt-br",
                                     "marketTypes": [
                                       {
                                         "specifierTypeId": 2,
                                         "specifierValue": 0.5,
                                         "id": 14,
                                         "name": ""
                                       }
                                     ]
                                   },
                                   {
                                     "text": "Real Betis: marcou gols no segundo tempo em cada um dos seus últimos 6 jogos",
                                     "locale": "pt-br",
                                     "marketTypes": [
                                       {
                                         "id": 4049,
                                         "name": ""
                                       }
                                     ]
                                   },
                                   {
                                     "text": "Levante: marcou gols no primeiro e no segundo tempo em cada um dos seus últimos 3 jogos.",
                                     "locale": "pt-br",
                                     "marketTypes": [
                                       {
                                         "id": 141,
                                         "name": ""
                                       }
                                     ]
                                   },
                                   {
                                     "text": "Real Betis: marcou mais gols no primeiro tempo em 50% dos jogos em casa nessa temporada ",
                                     "locale": "pt-br",
                                     "marketTypes": [
                                       {
                                         "id": 107,
                                         "name": ""
                                       }
                                     ]
                                   },
                                   {
                                     "text": "Real Betis ganhou 5 dos últimos 10 jogos contra Levante por dois ou mais gols de diferença",
                                     "locale": "pt-br",
                                     "marketTypes": [
                                       {
                                         "id": 185,
                                         "name": ""
                                       }
                                     ]
                                   },
                                   {
                                     "text": "Real Betis ganhou os 3 últimos jogos em casa contra Levante por dois ou mais gols de diferença",
                                     "locale": "pt-br",
                                     "marketTypes": [
                                       {
                                         "id": 185,
                                         "name": ""
                                       }
                                     ]
                                   },
                                   {
                                     "text": "La Liga: Levante ganhou apenas um de seus utimos 5 jogos fora de casa ",
                                     "locale": "pt-br",
                                     "marketTypes": [
                                       {
                                         "id": 1,
                                         "name": ""
                                       }
                                     ]
                                   },
                                   {
                                     "text": "C. Hernández marcou nos últimos  2 jogos em casa pelo Real Betis",
                                     "locale": "pt-br",
                                     "marketTypes": [
                                       {
                                         "id": 344,
                                         "name": ""
                                       }
                                     ]
                                   },
                                   {
                                     "text": "Real Betis ganhou seus últimos 2 jogos quando o(a)C. Hernández marcou",
                                     "locale": "pt-br",
                                     "marketTypes": [
                                       {
                                         "id": 344,
                                         "name": ""
                                       }
                                     ]
                                   },
                                   {
                                     "text": "Real Betis ganhou seus últimos 3 jogos em casa  quando o(a)C. Hernández marcou",
                                     "locale": "pt-br",
                                     "marketTypes": [
                                       {
                                         "id": 344,
                                         "name": ""
                                       }
                                     ]
                                   }
                                 ]
                               }
                             }
                             """;

            txtRawJson.Text = exemplo;
            ProcessarJsonText();
        }

        private void ProcessarJsonText()
        {
            string rawJson = txtRawJson.Text.Trim();
            if (string.IsNullOrWhiteSpace(rawJson))
            {
                MessageBox.Show("O campo JSON bruto está vazio.", "JSON Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                var response = JsonSerializer.Deserialize<JsonResponse>(rawJson, options);
                if (response?.D == null)
                {
                    MessageBox.Show("Não foi possível desserializar o JSON no formato esperado.", "Erro de Parsing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var container = response.D;

                // Preencher Jogo (Time A - Time B)
                if (container.Teams.Count >= 2)
                {
                    _parsedTeamAName = container.Teams[0].Name;
                    _parsedTeamBName = container.Teams[1].Name;
                    txtJogo.Text = $"{_parsedTeamAName} - {_parsedTeamBName}";
                }
                else if (container.Teams.Count == 1)
                {
                    _parsedTeamAName = container.Teams[0].Name;
                    _parsedTeamBName = "Time B";
                    txtJogo.Text = $"{_parsedTeamAName} - Sem Oponente";
                }
                else
                {
                    _parsedTeamAName = "Time A";
                    _parsedTeamBName = "Time B";
                    txtJogo.Text = "Sem times no JSON";
                }

                // Preencher Competição
                txtCompeticao.Text = container.League?.Name ?? string.Empty;

                // Preencher Data
                txtData.Text = FormatarData(container.StartTime);

                // Mapear Estatísticas
                if (container.Teams.Count >= 1)
                {
                    txtDadosTimeA.Text = ObterDadosTimeFormatados(container.Teams[0]);
                }
                else
                {
                    txtDadosTimeA.Text = string.Empty;
                }

                if (container.Teams.Count >= 2)
                {
                    txtDadosTimeB.Text = ObterDadosTimeFormatados(container.Teams[1]);
                }
                else
                {
                    txtDadosTimeB.Text = string.Empty;
                }

                // Preencher Insights/Notícias Relevantes
                var insightsList = new List<string>();
                foreach (var insight in container.Insights)
                {
                    if (!string.IsNullOrWhiteSpace(insight.Text))
                    {
                        insightsList.Add(insight.Text.Trim());
                    }
                }
                txtNoticias.Text = string.Join(Environment.NewLine, insightsList);
            }
            catch (JsonException jex)
            {
                MessageBox.Show($"Ocorreu um erro ao processar o formato do JSON:\n{jex.Message}", "JSON Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado ao processar o JSON:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FormatarData(string startTimeStr)
        {
            if (string.IsNullOrWhiteSpace(startTimeStr)) return string.Empty;

            if (DateTimeOffset.TryParse(startTimeStr, out var dto))
            {
                var culture = new CultureInfo("pt-BR");
                var localTime = dto.LocalDateTime;

                string dayOfWeek = culture.TextInfo.ToTitleCase(localTime.ToString("dddd", culture));
                string day = localTime.ToString("dd", culture);
                string month = culture.TextInfo.ToTitleCase(localTime.ToString("MMMM", culture));
                string year = localTime.ToString("yyyy", culture);
                string time = localTime.ToString("HH:mm", culture);

                return $"{dayOfWeek}, {day} {month} {year} {time}";
            }

            return startTimeStr;
        }

        private string ObterDadosTimeFormatados(Team team)
        {
            string golsMarcados = GetStatValue(team, 3, "Gols Marcados", "0");
            string mediaGolsMarcados = GetStatValue(team, 4, "Média de Gols Marcados", "0.0");
            string mediaGolsSofridos = GetStatValue(team, 5, "Média de Gols Sofridos", "0.0");
            string xg = GetStatValue(team, 6, "xGoals", "0.00");
            string mediaFinalizacoes = GetStatValue(team, 8, "Finalizações", "0.0");
            string mediaFinalizacoesGol = GetStatValue(team, 7, "Finalizações no Gol", "0.0");
            string posse = GetStatValue(team, 1, "Posse", "0");
            string semSofrerGols = GetStatValue(team, 13, "sem sofrer gols", "0");

            if (!posse.EndsWith("%") && double.TryParse(posse, NumberStyles.Any, CultureInfo.InvariantCulture, out _))
            {
                posse += "%";
            }

            return $"({golsMarcados}, {mediaGolsMarcados}, {mediaGolsSofridos}, {xg}, {mediaFinalizacoes}, {mediaFinalizacoesGol}, {posse}, {semSofrerGols})";
        }

        private string GetStatValue(Team team, int statId, string titleKeywords, string defaultVal)
        {
            if (team?.Statistics?.Items == null) return defaultVal;

            var item = team.Statistics.Items.Find(x => x.StatId == statId);
            if (item != null && !string.IsNullOrWhiteSpace(item.Value))
            {
                return item.Value.Trim();
            }

            item = team.Statistics.Items.Find(x => x.Title.Contains(titleKeywords, StringComparison.OrdinalIgnoreCase));
            if (item != null && !string.IsNullOrWhiteSpace(item.Value))
            {
                return item.Value.Trim();
            }

            return defaultVal;
        }

        private void GerarProbabilidades(object? sender, EventArgs e)
        {
            string jogo = txtJogo.Text.Trim();
            string competicao = txtCompeticao.Text.Trim();
            string data = txtData.Text.Trim();
            string mediaGolsLiga = txtMediaGolsLiga.Text.Trim();

            string dadosTimeA = txtDadosTimeA.Text.Trim();
            string dadosTimeB = txtDadosTimeB.Text.Trim();
            string noticias = txtNoticias.Text.Trim();

            string teamNameA = _parsedTeamAName;
            string teamNameB = _parsedTeamBName;

            int hyphenIndex = jogo.IndexOf('-');
            if (hyphenIndex > 0)
            {
                teamNameA = jogo.Substring(0, hyphenIndex).Trim();
                teamNameB = jogo.Substring(hyphenIndex + 1).Trim();
            }

            var sb = new System.Text.StringBuilder();
            sb.AppendLine($"[JOGO]{jogo}, [COMPETIÇÃO] {competicao} [DATA]{data}, [MÉDIA_GOLS_LIGA] {mediaGolsLiga}");
            sb.AppendLine();
            sb.AppendLine($"[{teamNameA}]: {dadosTimeA}");
            sb.AppendLine();
            sb.AppendLine($"[{teamNameB}]: {dadosTimeB}");
            sb.AppendLine();
            sb.AppendLine("[NOTÍCIAS RELEVANTES]");
            sb.AppendLine(noticias);

            txtOutputFinal.Text = sb.ToString();
        }

        #endregion

        #region Logica da Aba 2 (Cálculo de ODDs)

        private void CarregarExemploOdds(object? sender, EventArgs e)
        {
            string exemploJson = """
                                 {
                                   "qualificados": [
                                     {
                                       "mercado": "Over 0.5 Gols",
                                       "prob": 0.9419
                                     },
                                     {
                                       "mercado": "Under 3.5 Gols",
                                       "prob": 0.8123
                                     },
                                     {
                                       "mercado": "Under 4.5 Gols",
                                       "prob": 0.9388
                                     },
                                     {
                                       "mercado": "Under 5.5 Gols",
                                       "prob": 0.9842
                                     }
                                   ]
                                 }
                                 """;
            txtOddsJson.Text = exemploJson;
        }

        private void ProcessarOdds(object? sender, EventArgs e)
        {
            string rawJson = txtOddsJson.Text.Trim();
            if (string.IsNullOrWhiteSpace(rawJson))
            {
                MessageBox.Show("O campo JSON de mercados está vazio.", "JSON Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Normalizar JSON fragmentado (ex: "qualificados": [ ... ] sem as chaves '{ }' ou com vírgula no final)
            string cleanedJson = rawJson;
            if (!cleanedJson.StartsWith("{"))
            {
                if (cleanedJson.EndsWith(","))
                {
                    cleanedJson = cleanedJson.Substring(0, cleanedJson.Length - 1).Trim();
                }
                cleanedJson = "{" + cleanedJson + "}";
            }

            try
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                var container = JsonSerializer.Deserialize<QualifiedMarketsContainer>(cleanedJson, options);
                if (container?.Qualificados == null || container.Qualificados.Count == 0)
                {
                    MessageBox.Show("Não foi possível encontrar uma lista de mercados qualificados ('qualificados') válida no JSON.", "Erro de Parsing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var resultados = new List<string>();

                foreach (var market in container.Qualificados)
                {
                    // Exibir o diálogo para solicitar a ODD
                    using (var dialog = new OddInputDialog(market.Mercado, market.Prob))
                    {
                        var dialogResult = dialog.ShowDialog(this);
                        if (dialogResult == DialogResult.Cancel)
                        {
                            MessageBox.Show("Operação cancelada pelo usuário. O processamento foi interrompido.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        // Normalizar o valor da probabilidade (prob * 100 se for decimal, ou prob direto se for percentual)
                        double percentProb = market.Prob;
                        if (percentProb <= 1.0)
                        {
                            percentProb *= 100.0;
                        }
                        string probFormatted = percentProb.ToString("0.00", CultureInfo.InvariantCulture);

                        // Formatar a ODD digitada (com vírgula como separador decimal)
                        string oddFormatted = dialog.ResultOdd.ToString("0.00", new CultureInfo("pt-BR"));

                        // Formatar o nome do mercado conforme a regra:
                        // Se começar com "Under" e terminar com " Gols", remover " Gols".
                        string mercadoNome = market.Mercado.Trim();
                        if (mercadoNome.StartsWith("Under", StringComparison.OrdinalIgnoreCase) && mercadoNome.EndsWith(" Gols", StringComparison.OrdinalIgnoreCase))
                        {
                            mercadoNome = mercadoNome.Substring(0, mercadoNome.Length - 5).Trim();
                        }

                        resultados.Add($"Mercado: [{mercadoNome}], Probabilidade: {probFormatted}, Odd Atual: {oddFormatted}");
                    }
                }

                // Escrever o resultado consolidado no TextBox de Saída
                txtOddsOutput.Text = string.Join(Environment.NewLine, resultados);
            }
            catch (JsonException jex)
            {
                MessageBox.Show($"Formato JSON inválido. Certifique-se de que é um objeto JSON válido ou um fragmento no formato \"qualificados\": [...]\n\nErro: {jex.Message}", "Erro de JSON", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao processar as ODDs:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Logica da Aba 3 (Analisa de Resultados)

        private void CarregarExemploAnalise(object? sender, EventArgs e)
        {
            string exemploJson = """
                                 {
                                   "jogo": "Corinthians vs Atlético-MG",
                                   "campeonato": "Brasileirão - Série A Betano",
                                   "data": "24/05/2026",
                                   "resumo_lesoes": "Corinthians sem Charles Rigon, Memphis Depay, João Pedro, Kayke e Vitinho. Atlético-MG sem Ruan Tressoldi, Gustavo Scarpa e Patrick.",
                                   "raciocinio": "A análise quantitativa via Poisson indica uma forte tendência Under para a partida. Ambas as equipes possuem desfalques de peso no setor de criação e ataque (destaque para Memphis Depay no Corinthians e Gustavo Scarpa no Atlético-MG), reduzindo o poder ofensivo histórico. O volume moderado de finalizações certas corrobora o cenário de poucos gols.",
                                   "historico_gols": {
                                     "time_a": 0.9,
                                     "time_b": 1.3
                                   },
                                   "probabilidades": [
                                     {"mercado": "Over 0.5", "prob": 82.52},
                                     {"mercado": "Under 5.5", "prob": 99.88},
                                     {"mercado": "Under 4.5", "prob": 99.19},
                                     {"mercado": "Under 3.5", "prob": 95.34},
                                     {"mercado": "Under 2.5", "prob": 81.39},
                                     {"mercado": "Over 1.5", "prob": 49.33},
                                     {"mercado": "Over 2.5", "prob": 18.61},
                                     {"mercado": "Under 1.5", "prob": 50.67},
                                     {"mercado": "Under 0.5", "prob": 17.48},
                                     {"mercado": "Handicap Asiático 0.0 (Corinthians)", "prob": 30.15},
                                     {"mercado": "Handicap Asiático 0.0 (Atlético-MG)", "prob": 52.37}
                                   ],
                                   "qualificados": [
                                     {"mercado": "Over 0.5", "prob": 82.52},
                                     {"mercado": "Under 5.5", "prob": 99.88},
                                     {"mercado": "Under 4.5", "prob": 99.19},
                                     {"mercado": "Under 3.5", "prob": 95.34},
                                     {"mercado": "Under 2.5", "prob": 81.39}
                                   ],
                                   "debug_calculo": {
                                     "lambda_time_a": 0.7744,
                                     "lambda_time_b": 0.9702
                                   }
                                 }
                                 """;
            txtAnalysisJson.Text = exemploJson;
        }

        private void ProcessarAnalise(object? sender, EventArgs e)
        {
            string rawJson = txtAnalysisJson.Text.Trim();
            if (string.IsNullOrWhiteSpace(rawJson))
            {
                MessageBox.Show("O campo JSON de análise está vazio.", "JSON Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Normalizar JSON fragmentado
            string cleanedJson = rawJson;
            if (!cleanedJson.StartsWith("{"))
            {
                if (cleanedJson.EndsWith(","))
                {
                    cleanedJson = cleanedJson.Substring(0, cleanedJson.Length - 1).Trim();
                }
                cleanedJson = "{" + cleanedJson + "}";
            }

            try
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                var analysis = JsonSerializer.Deserialize<MatchAnalysis>(cleanedJson, options);
                if (analysis == null)
                {
                    MessageBox.Show("Não foi possível desserializar o JSON de análise.", "Erro de Parsing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _lastMatchAnalysis = analysis;

                // Preencher campos com Scroll
                txtAnalysisResumoLesoes.Text = analysis.ResumoLesoes;
                txtAnalysisRaciocinio.Text = analysis.Raciocinio;

                // Montar relatório de saída formatado no TextBox principal
                var sb = new System.Text.StringBuilder();
                sb.AppendLine($"[CAMPEONATO] {analysis.Campeonato}");
                sb.AppendLine($"[JOGO] {analysis.Jogo}");
                sb.AppendLine($"[DATA] {analysis.Data}");
                sb.AppendLine();

                if (analysis.HistoricoGols != null)
                {
                    sb.AppendLine("[HISTÓRICO DE GOLS]");
                    sb.AppendLine($"Time A: {analysis.HistoricoGols.TimeA.ToString("0.0", CultureInfo.InvariantCulture)} | Time B: {analysis.HistoricoGols.TimeB.ToString("0.0", CultureInfo.InvariantCulture)}");
                    sb.AppendLine();
                }

                if (analysis.DebugCalculo != null)
                {
                    sb.AppendLine("[DEBUG CÁLCULO]");
                    sb.AppendLine($"Lambda Time A: {analysis.DebugCalculo.LambdaTimeA.ToString("0.0000", CultureInfo.InvariantCulture)} | Lambda Time B: {analysis.DebugCalculo.LambdaTimeB.ToString("0.0000", CultureInfo.InvariantCulture)}");
                    sb.AppendLine();
                }

                if (analysis.Probabilidades != null && analysis.Probabilidades.Count > 0)
                {
                    sb.AppendLine("[PROBABILIDADES]");
                    sb.AppendLine(FormatMarketsList(analysis.Probabilidades));
                    sb.AppendLine();
                }

                if (analysis.Qualificados != null && analysis.Qualificados.Count > 0)
                {
                    sb.AppendLine("[QUALIFICADOS]");
                    sb.AppendLine(FormatMarketsList(analysis.Qualificados));
                }

                txtAnalysisOutput.Text = sb.ToString();
            }
            catch (JsonException jex)
            {
                MessageBox.Show($"Formato JSON inválido. Certifique-se de que é um objeto JSON válido contendo os campos de análise de partida.\n\nErro: {jex.Message}", "Erro de JSON", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao processar a análise:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FormatMarketsList(List<QualifiedMarket> list)
        {
            var lines = new List<string>();
            foreach (var item in list)
            {
                double probVal = item.Prob;
                if (probVal <= 1.0)
                {
                    probVal *= 100.0;
                }
                lines.Add($"- {item.Mercado}: {probVal.ToString("0.00", CultureInfo.InvariantCulture)}%");
            }
            return string.Join(Environment.NewLine, lines);
        }

        private void SalvarAnalise(object? sender, EventArgs e)
        {
            if (_lastMatchAnalysis == null)
            {
                MessageBox.Show("Nenhuma análise processada recentemente. Por favor, processe um JSON de análise primeiro antes de salvar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var connection = new SqliteConnection($"Data Source={_dbPath}"))
                {
                    connection.Open();
                    string insertQuery = """
                        INSERT INTO Bets (Campeonato, Jogo, Data, HistoricoGols, DebugCalculo, Probabilidades, Qualificados, ResumoLesoes, Raciocinio, DataRegistro)
                        VALUES (@Campeonato, @Jogo, @Data, @HistoricoGols, @DebugCalculo, @Probabilidades, @Qualificados, @ResumoLesoes, @Raciocinio, datetime('now', 'localtime'));
                        """;

                    using (var command = new SqliteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Campeonato", _lastMatchAnalysis.Campeonato);
                        command.Parameters.AddWithValue("@Jogo", _lastMatchAnalysis.Jogo);
                        command.Parameters.AddWithValue("@Data", _lastMatchAnalysis.Data);

                        string histGols = _lastMatchAnalysis.HistoricoGols != null
                            ? $"Time A: {_lastMatchAnalysis.HistoricoGols.TimeA.ToString("0.0", CultureInfo.InvariantCulture)} | Time B: {_lastMatchAnalysis.HistoricoGols.TimeB.ToString("0.0", CultureInfo.InvariantCulture)}"
                            : "";
                        command.Parameters.AddWithValue("@HistoricoGols", histGols);

                        string debugCalc = _lastMatchAnalysis.DebugCalculo != null
                            ? $"Lambda Time A: {_lastMatchAnalysis.DebugCalculo.LambdaTimeA.ToString("0.0000", CultureInfo.InvariantCulture)} | Lambda Time B: {_lastMatchAnalysis.DebugCalculo.LambdaTimeB.ToString("0.0000", CultureInfo.InvariantCulture)}"
                            : "";
                        command.Parameters.AddWithValue("@DebugCalculo", debugCalc);

                        command.Parameters.AddWithValue("@Probabilidades", FormatMarketsList(_lastMatchAnalysis.Probabilidades));
                        command.Parameters.AddWithValue("@Qualificados", FormatMarketsList(_lastMatchAnalysis.Qualificados));
                        command.Parameters.AddWithValue("@ResumoLesoes", _lastMatchAnalysis.ResumoLesoes);
                        command.Parameters.AddWithValue("@Raciocinio", _lastMatchAnalysis.Raciocinio);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Resultados da aposta salvos com sucesso no histórico!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHistoryGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar aposta no banco de dados SQLite:\n{ex.Message}", "Erro de Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Logica da Aba 4 (Probabilidades Realizadas)

        private void DgvHistory_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvHistory.SelectedRows.Count == 0)
            {
                ClearHistoryDetails();
                return;
            }

            try
            {
                var selectedRow = dgvHistory.SelectedRows[0];
                int recordId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                using (var connection = new SqliteConnection($"Data Source={_dbPath}"))
                {
                    connection.Open();
                    string selectQuery = "SELECT Campeonato, Jogo, Data, HistoricoGols, DebugCalculo, Probabilidades, Qualificados, ResumoLesoes, Raciocinio FROM Bets WHERE Id = @Id";
                    using (var command = new SqliteCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Id", recordId);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string campeonato = reader.IsDBNull(0) ? "" : reader.GetString(0);
                                string jogo = reader.IsDBNull(1) ? "" : reader.GetString(1);
                                string data = reader.IsDBNull(2) ? "" : reader.GetString(2);
                                string histGols = reader.IsDBNull(3) ? "" : reader.GetString(3);
                                string debugCalc = reader.IsDBNull(4) ? "" : reader.GetString(4);
                                string probs = reader.IsDBNull(5) ? "" : reader.GetString(5);
                                string quals = reader.IsDBNull(6) ? "" : reader.GetString(6);
                                string resumoLesoes = reader.IsDBNull(7) ? "" : reader.GetString(7);
                                string raciocinio = reader.IsDBNull(8) ? "" : reader.GetString(8);

                                // Reconstrói o formato estruturado do relatório
                                var sb = new System.Text.StringBuilder();
                                sb.AppendLine($"[CAMPEONATO] {campeonato}");
                                sb.AppendLine($"[JOGO] {jogo}");
                                sb.AppendLine($"[DATA] {data}");
                                sb.AppendLine();

                                if (!string.IsNullOrWhiteSpace(histGols))
                                {
                                    sb.AppendLine("[HISTÓRICO DE GOLS]");
                                    sb.AppendLine(histGols);
                                    sb.AppendLine();
                                }

                                if (!string.IsNullOrWhiteSpace(debugCalc))
                                {
                                    sb.AppendLine("[DEBUG CÁLCULO]");
                                    sb.AppendLine(debugCalc);
                                    sb.AppendLine();
                                }

                                if (!string.IsNullOrWhiteSpace(probs))
                                {
                                    sb.AppendLine("[PROBABILIDADES]");
                                    sb.AppendLine(probs);
                                    sb.AppendLine();
                                }

                                if (!string.IsNullOrWhiteSpace(quals))
                                {
                                    sb.AppendLine("[QUALIFICADOS]");
                                    sb.AppendLine(quals);
                                }

                                txtHistoryDetails.Text = sb.ToString();
                                txtHistoryResumoLesoes.Text = resumoLesoes;
                                txtHistoryRaciocinio.Text = raciocinio;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar detalhes da aposta:\n{ex.Message}", "Erro de Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExcluirAposta(object? sender, EventArgs e)
        {
            if (dgvHistory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma aposta selecionada no Grid para exclusão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Deseja realmente excluir esta aposta registrada permanentemente do histórico?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var selectedRow = dgvHistory.SelectedRows[0];
                    int recordId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                    using (var connection = new SqliteConnection($"Data Source={_dbPath}"))
                    {
                        connection.Open();
                        string deleteQuery = "DELETE FROM Bets WHERE Id = @Id";
                        using (var command = new SqliteCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Id", recordId);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Aposta registrada excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHistoryGrid();
                    ClearHistoryDetails();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir aposta do banco de dados:\n{ex.Message}", "Erro de Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearHistoryDetails()
        {
            txtHistoryDetails.Text = string.Empty;
            txtHistoryResumoLesoes.Text = string.Empty;
            txtHistoryRaciocinio.Text = string.Empty;
        }

        #endregion

        #region Logica da Aba 5 (Odd's Realizadas)

        private void StyleRealizedGrid()
        {
            dgvRealized.EnableHeadersVisualStyles = false;
            dgvRealized.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 23, 42);
            dgvRealized.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(56, 189, 248);
            dgvRealized.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvRealized.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgvRealized.DefaultCellStyle.BackColor = Color.FromArgb(39, 39, 42);
            dgvRealized.DefaultCellStyle.ForeColor = Color.White;
            dgvRealized.DefaultCellStyle.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dgvRealized.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvRealized.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);

            dgvRealized.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(28, 28, 30);
            dgvRealized.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            dgvRealized.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dgvRealized.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;

            dgvRealized.RowHeadersVisible = false;
            dgvRealized.GridColor = Color.FromArgb(63, 63, 70);
            dgvRealized.BorderStyle = BorderStyle.None;
            dgvRealized.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRealized.MultiSelect = false;
            dgvRealized.ReadOnly = true;
            dgvRealized.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadRealizedGrid()
        {
            try
            {
                var dt = new DataTable();
                using (var connection = new SqliteConnection($"Data Source={_dbPath}"))
                {
                    connection.Open();
                    string selectQuery = "SELECT Id, Campeonato, Jogo, Data, Bet, Valor, ValorApostado, Status FROM RealizedOdds";

                    if (chkFilterDate.Checked)
                    {
                        selectQuery += " WHERE Data = @FilterDate";
                    }
                    selectQuery += " ORDER BY Id DESC";

                    using (var command = new SqliteCommand(selectQuery, connection))
                    {
                        if (chkFilterDate.Checked)
                        {
                            command.Parameters.AddWithValue("@FilterDate", dtpFilterDate.Value.ToString("dd/MM/yyyy"));
                        }

                        using (var reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }

                // Add calculated Retorno column to the DataTable
                dt.Columns.Add("Retorno", typeof(double));
                foreach (DataRow row in dt.Rows)
                {
                    string status = row["Status"]?.ToString() ?? "Pendente";
                    
                    double odd = 0.0;
                    if (row["Valor"] != null && row["Valor"] != DBNull.Value)
                        odd = Convert.ToDouble(row["Valor"]);
                        
                    double stake = 0.0;
                    if (row["ValorApostado"] != null && row["ValorApostado"] != DBNull.Value)
                        stake = Convert.ToDouble(row["ValorApostado"]);
                    
                    if (status == "Ganho")
                    {
                        row["Retorno"] = stake * odd;
                    }
                    else
                    {
                        row["Retorno"] = 0.0;
                    }
                }

                dgvRealized.DataSource = dt;

                // Adjust column headers and visibility
                var colId = dgvRealized.Columns["Id"];
                if (colId != null) colId.Visible = false;

                var colCampeonato = dgvRealized.Columns["Campeonato"];
                if (colCampeonato != null) colCampeonato.HeaderText = "Campeonato";

                var colJogo = dgvRealized.Columns["Jogo"];
                if (colJogo != null) colJogo.HeaderText = "Jogo";

                var colData = dgvRealized.Columns["Data"];
                if (colData != null) colData.HeaderText = "Data";

                var colBet = dgvRealized.Columns["Bet"];
                if (colBet != null) colBet.HeaderText = "Aposta";

                var colValor = dgvRealized.Columns["Valor"];
                if (colValor != null)
                {
                    colValor.HeaderText = "Odd";
                    colValor.DefaultCellStyle.Format = "N2";
                }

                var colValorApostado = dgvRealized.Columns["ValorApostado"];
                if (colValorApostado != null)
                {
                    colValorApostado.HeaderText = "Valor (R$)";
                    colValorApostado.DefaultCellStyle.Format = "C2";
                    colValorApostado.DefaultCellStyle.FormatProvider = new CultureInfo("pt-BR");
                }

                var colStatus = dgvRealized.Columns["Status"];
                if (colStatus != null)
                    colStatus.HeaderText = "Status";

                var colRetorno = dgvRealized.Columns["Retorno"];
                if (colRetorno != null)
                {
                    colRetorno.HeaderText = "Retorno (R$)";
                    colRetorno.DefaultCellStyle.Format = "C2";
                    colRetorno.DefaultCellStyle.FormatProvider = new CultureInfo("pt-BR");
                }

                // Recalculate totals
                RecalculateRealizedTotals();
                UpdateDayTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar histórico de odds realizadas:\n{ex.Message}", "Erro de Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RecalculateRealizedTotals()
        {
            double total = 0;
            foreach (DataGridViewRow row in dgvRealized.Rows)
            {
                var statusObj = row.Cells["Status"].Value;
                if (statusObj == null || statusObj == DBNull.Value) continue;
                string status = statusObj.ToString() ?? "";

                double valor = 0;
                var valorObj = row.Cells["Valor"].Value;
                if (valorObj != null && valorObj != DBNull.Value)
                    valor = Convert.ToDouble(valorObj);

                double valorApostado = 0;
                var valorApostadoObj = row.Cells["ValorApostado"].Value;
                if (valorApostadoObj != null && valorApostadoObj != DBNull.Value)
                    valorApostado = Convert.ToDouble(valorApostadoObj);

                if (status == "Ganho")
                {
                    total += valorApostado * (valor - 1.0);
                }
                else if (status == "Perda")
                {
                    total -= valorApostado;
                }
            }

            lblTotalResultValue.Text = $"R$ {total.ToString("N2", new CultureInfo("pt-BR"))}";
            if (total > 0)
            {
                lblTotalResultValue.ForeColor = Color.FromArgb(74, 222, 128); // Green
            }
            else if (total < 0)
            {
                lblTotalResultValue.ForeColor = Color.FromArgb(248, 113, 113); // Red
            }
            else
            {
                lblTotalResultValue.ForeColor = Color.White;
            }
        }

        private void UpdateDayTotal()
        {
            try
            {
                int totalCount = 0;
                double totalSum = 0.0;

                int successCount = 0;
                double successNet = 0.0;

                int lossCount = 0;
                double lossNet = 0.0;

                string targetDate = dtpFilterDate.Value.ToString("dd/MM/yyyy");

                using (var connection = new SqliteConnection($"Data Source={_dbPath}"))
                {
                    connection.Open();
                    string query = "SELECT Status, Valor, ValorApostado FROM RealizedOdds WHERE Data = @FilterDate";
                    using (var command = new SqliteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FilterDate", targetDate);
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string status = reader.IsDBNull(0) ? "Pendente" : reader.GetString(0);
                                double odd = reader.IsDBNull(1) ? 0.0 : reader.GetDouble(1);
                                double stake = reader.IsDBNull(2) ? 0.0 : reader.GetDouble(2);

                                totalCount++;
                                totalSum += stake;

                                if (status == "Ganho")
                                {
                                    successCount++;
                                    successNet += stake * (odd - 1.0);
                                }
                                else if (status == "Perda")
                                {
                                    lossCount++;
                                    lossNet += stake;
                                }
                            }
                        }
                    }
                }

                var culture = new CultureInfo("pt-BR");
                lblDayTotal.Text = $"Total de Apostas no dia {targetDate}: {totalCount} aposta(s) (R$ {totalSum.ToString("N2", culture)} apostados)\r\n" +
                                   $"  • Sucesso: {successCount} aposta(s) (R$ {successNet.ToString("N2", culture)})\r\n" +
                                   $"  • Perda: {lossCount} aposta(s) (R$ {lossNet.ToString("N2", culture)})";
            }
            catch (Exception)
            {
                lblDayTotal.Text = "Erro ao calcular total do dia.";
            }
        }

        private void SalvarRealizadas(object? sender, EventArgs e)
        {
            string inputText = txtRealizedInput.Text.Trim();
            if (string.IsNullOrEmpty(inputText))
            {
                MessageBox.Show("Por favor, cole um bloco de texto com as informações da aposta antes de cadastrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Normaliza quebras de linha e múltiplos espaços para facilitar o parsing Regex flexível
                string normalizedText = inputText.Replace("\r", " ").Replace("\n", " ");
                normalizedText = System.Text.RegularExpressions.Regex.Replace(normalizedText, @"\s+", " ");

                string campeonato = "";
                string jogo = "";
                string data = "";

                var mCamp = System.Text.RegularExpressions.Regex.Match(normalizedText, @"\[CAMPEONATO\]\s*(.*?)\s*(?=\[JOGO\]|\[DATA\]|\[BET\]|Mercado:|$)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (mCamp.Success) campeonato = mCamp.Groups[1].Value.Trim();

                var mJogo = System.Text.RegularExpressions.Regex.Match(normalizedText, @"\[JOGO\]\s*(.*?)\s*(?=\[CAMPEONATO\]|\[DATA\]|\[BET\]|Mercado:|$)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (mJogo.Success) jogo = mJogo.Groups[1].Value.Trim();

                var mData = System.Text.RegularExpressions.Regex.Match(normalizedText, @"\[DATA\]\s*(.*?)\s*(?=\[CAMPEONATO\]|\[JOGO\]|\[BET\]|Mercado:|$)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (mData.Success) data = mData.Groups[1].Value.Trim();

                var bets = new List<(string bet, double odd, double valor)>();

                // Verifica se os dados contêm o formato "Mercado:"
                if (normalizedText.Contains("Mercado:", StringComparison.OrdinalIgnoreCase))
                {
                    var matches = System.Text.RegularExpressions.Regex.Matches(normalizedText, 
                        @"Mercado:\s*\[(.*?)\]\s*,\s*Probabilidade:\s*([\d,\.\%]+)\s*,\s*Odd Atual:\s*([\d,\.]+)\s*,\s*Stake:\s*([\d,\.]+)", 
                        System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    
                    foreach (System.Text.RegularExpressions.Match match in matches)
                    {
                        string market = match.Groups[1].Value.Trim();
                        string prob = match.Groups[2].Value.Trim();
                        string oddStr = match.Groups[3].Value.Trim().Replace(",", ".");
                        string stakeStr = match.Groups[4].Value.Trim().Replace(",", ".");
                        
                        double oddVal = 1.0;
                        double stakeVal = 10.0;
                        
                        double.TryParse(oddStr, NumberStyles.Any, CultureInfo.InvariantCulture, out oddVal);
                        double.TryParse(stakeStr, NumberStyles.Any, CultureInfo.InvariantCulture, out stakeVal);
                        
                        // Combina nome do mercado e probabilidade para o formato BET existente
                        string betField = $"{market}: {prob}";
                        if (!betField.Contains("%") && double.TryParse(prob.Replace("%", "").Replace(",", "."), out double _))
                        {
                            betField += "%";
                        }
                        
                        bets.Add((betField, oddVal, stakeVal));
                    }
                }
                else
                {
                    // Caso clássico: [BET], [ODD] e [VALOR]
                    var matches = System.Text.RegularExpressions.Regex.Matches(normalizedText, 
                        @"\[BET\]\s*(.*?)\s*(?:\[ODD\]\s*([\d,\.]+)\s*)?\[VALOR\]\s*([\d,\.]+)", 
                        System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    
                    foreach (System.Text.RegularExpressions.Match match in matches)
                    {
                        string betDesc = match.Groups[1].Value.Trim();
                        string oddStr = match.Groups[2].Value.Trim().Replace(",", ".");
                        string valorStr = match.Groups[3].Value.Trim().Replace(",", ".");
                        
                        double oddVal = 1.0;
                        double stakeVal = 10.0;
                        
                        bool hasOdd = !string.IsNullOrEmpty(match.Groups[2].Value);
                        
                        double.TryParse(valorStr, NumberStyles.Any, CultureInfo.InvariantCulture, out double parsedValor);
                        
                        if (hasOdd)
                        {
                            double.TryParse(oddStr, NumberStyles.Any, CultureInfo.InvariantCulture, out oddVal);
                            stakeVal = parsedValor;
                        }
                        else
                        {
                            if (parsedValor < 20.0)
                            {
                                oddVal = parsedValor;
                                stakeVal = 10.0;
                            }
                            else
                            {
                                oddVal = 2.0;
                                stakeVal = parsedValor;
                            }
                        }
                        
                        bets.Add((betDesc, oddVal, stakeVal));
                    }
                }

                if (bets.Count == 0)
                {
                    MessageBox.Show("Nenhuma aposta identificada. Verifique se o formato colado é válido.", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Valores padrão caso faltem metadados
                if (string.IsNullOrEmpty(campeonato)) campeonato = "Geral";
                if (string.IsNullOrEmpty(jogo)) jogo = "Jogo Indefinido";
                if (string.IsNullOrEmpty(data)) data = DateTime.Now.ToString("dd/MM/yyyy");

                // Salva no banco de dados SQLite
                using (var connection = new SqliteConnection($"Data Source={_dbPath}"))
                {
                    connection.Open();
                    string insertQuery = """
                        INSERT INTO RealizedOdds (Campeonato, Jogo, Data, Bet, Valor, ValorApostado, Status, DataRegistro)
                        VALUES (@Campeonato, @Jogo, @Data, @Bet, @Valor, @ValorApostado, 'Pendente', datetime('now', 'localtime'));
                        """;

                    foreach (var betItem in bets)
                    {
                        using (var command = new SqliteCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Campeonato", campeonato);
                            command.Parameters.AddWithValue("@Jogo", jogo);
                            command.Parameters.AddWithValue("@Data", data);
                            command.Parameters.AddWithValue("@Bet", betItem.bet);
                            command.Parameters.AddWithValue("@Valor", betItem.odd);
                            command.Parameters.AddWithValue("@ValorApostado", betItem.valor);
                            command.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show($"{bets.Count} aposta(s) cadastrada(s) com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRealizedInput.Text = string.Empty;
                LoadRealizedGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar apostas:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExcluirRealizada(object? sender, EventArgs e)
        {
            if (dgvRealized.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma aposta selecionada no Grid para exclusão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Deseja realmente excluir esta aposta cadastrada permanentemente do histórico?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var selectedRow = dgvRealized.SelectedRows[0];
                    int recordId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                    using (var connection = new SqliteConnection($"Data Source={_dbPath}"))
                    {
                        connection.Open();
                        string deleteQuery = "DELETE FROM RealizedOdds WHERE Id = @Id";
                        using (var command = new SqliteCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Id", recordId);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Aposta excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRealizedGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir aposta do banco de dados:\n{ex.Message}", "Erro de Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DgvRealized_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                var row = dgvRealized.Rows[e.RowIndex];
                int recordId = Convert.ToInt32(row.Cells["Id"].Value);
                string currentStatus = row.Cells["Status"].Value?.ToString() ?? "Pendente";

                string newStatus = "Pendente";
                if (currentStatus == "Pendente")
                {
                    newStatus = "Ganho";
                }
                else if (currentStatus == "Ganho")
                {
                    newStatus = "Perda";
                }
                else if (currentStatus == "Perda")
                {
                    newStatus = "Pendente";
                }

                using (var connection = new SqliteConnection($"Data Source={_dbPath}"))
                {
                    connection.Open();
                    string updateQuery = "UPDATE RealizedOdds SET Status = @Status WHERE Id = @Id";
                    using (var command = new SqliteCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Status", newStatus);
                        command.Parameters.AddWithValue("@Id", recordId);
                        command.ExecuteNonQuery();
                    }
                }

                LoadRealizedGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar status da aposta:\n{ex.Message}", "Erro de Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvRealized_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvRealized.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string statusVal = e.Value.ToString() ?? "";
                if (statusVal == "Ganho")
                {
                    e.Value = "Sucesso";
                    e.CellStyle.ForeColor = Color.FromArgb(74, 222, 128); // Green
                    e.CellStyle.SelectionForeColor = Color.FromArgb(74, 222, 128);
                }
                else if (statusVal == "Perda")
                {
                    e.Value = "Perda";
                    e.CellStyle.ForeColor = Color.FromArgb(248, 113, 113); // Red
                    e.CellStyle.SelectionForeColor = Color.FromArgb(248, 113, 113);
                }
                else
                {
                    e.Value = "Pendente";
                    e.CellStyle.ForeColor = Color.FromArgb(156, 163, 175); // Gray
                    e.CellStyle.SelectionForeColor = Color.FromArgb(156, 163, 175);
                }
                e.FormattingApplied = true;
            }
        }

        #endregion
    }
}
