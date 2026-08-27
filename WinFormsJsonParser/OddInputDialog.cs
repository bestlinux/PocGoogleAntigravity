using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace WinFormsJsonParser
{
    public class OddInputDialog : Form
    {
        private Label lblMarketInfo = null!;
        private Label lblPrompt = null!;
        private TextBox txtOddValue = null!;
        private Button btnOk = null!;
        private Button btnCancel = null!;

        public double ResultOdd { get; private set; }

        public OddInputDialog(string marketName, double probability)
        {
            // Normaliza a probabilidade: se for <= 1.0 (ex: 0.9419), converte em percentual (ex: 94.19)
            double displayProb = probability;
            if (displayProb <= 1.0)
            {
                displayProb *= 100.0;
            }
            InitializeComponent(marketName, displayProb);
        }

        private void InitializeComponent(string marketName, double probability)
        {
            this.Size = new Size(400, 240);
            this.Text = "Inserir ODD";
            this.BackColor = Color.FromArgb(24, 24, 27);
            this.ForeColor = Color.FromArgb(228, 228, 231);
            this.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Info panel
            lblMarketInfo = new Label
            {
                Location = new Point(20, 20),
                Size = new Size(360, 50),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point),
                ForeColor = Color.FromArgb(56, 189, 248),
                Text = $"Mercado: {marketName}\nProbabilidade: {probability.ToString("0.00", CultureInfo.InvariantCulture)}%"
            };

            lblPrompt = new Label
            {
                Location = new Point(20, 80),
                Size = new Size(360, 20),
                ForeColor = Color.FromArgb(161, 161, 170),
                Text = "Informe a ODD atual disponível:"
            };

            txtOddValue = new TextBox
            {
                Location = new Point(20, 105),
                Size = new Size(345, 25),
                BackColor = Color.FromArgb(39, 39, 42),
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
            };
            // Ao pressionar Enter, simula clique no OK
            txtOddValue.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    btnOk.PerformClick();
                }
            };

            btnOk = new Button
            {
                Location = new Point(140, 150),
                Size = new Size(110, 35),
                BackColor = Color.FromArgb(16, 185, 129),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point),
                Text = "Confirmar",
                Cursor = Cursors.Hand
            };
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.Click += BtnOk_Click;

            btnCancel = new Button
            {
                Location = new Point(255, 150),
                Size = new Size(110, 35),
                BackColor = Color.FromArgb(75, 85, 99),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point),
                Text = "Cancelar",
                Cursor = Cursors.Hand
            };
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };

            // Hover effects
            AddHoverEffect(btnOk, Color.FromArgb(16, 185, 129), Color.FromArgb(52, 211, 153));
            AddHoverEffect(btnCancel, Color.FromArgb(75, 85, 99), Color.FromArgb(107, 114, 128));

            this.Controls.Add(lblMarketInfo);
            this.Controls.Add(lblPrompt);
            this.Controls.Add(txtOddValue);
            this.Controls.Add(btnOk);
            this.Controls.Add(btnCancel);

            // Foco inicial no campo de digitação
            this.ActiveControl = txtOddValue;
        }

        private void AddHoverEffect(Button btn, Color normal, Color hover)
        {
            btn.MouseEnter += (s, e) => btn.BackColor = hover;
            btn.MouseLeave += (s, e) => btn.BackColor = normal;
        }

        private void BtnOk_Click(object? sender, EventArgs e)
        {
            string inputText = txtOddValue.Text.Trim();
            if (string.IsNullOrWhiteSpace(inputText))
            {
                MessageBox.Show("Por favor, informe um valor de ODD.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOddValue.Focus();
                return;
            }

            // Normalizar separador para conversão (aceitar tanto vírgula quanto ponto)
            string normalizedInput = inputText.Replace(',', '.');

            if (double.TryParse(normalizedInput, NumberStyles.Any, CultureInfo.InvariantCulture, out double parsedOdd) && parsedOdd >= 0)
            {
                ResultOdd = parsedOdd;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, informe uma ODD decimal válida e maior ou igual a zero (exemplo: 1.16 ou 0,00).", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOddValue.Focus();
                txtOddValue.SelectAll();
            }
        }
    }
}
