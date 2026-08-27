using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WinFormsJsonParser
{
    public class JsonResponse
    {
        [JsonPropertyName("d")]
        public DataContainer D { get; set; } = new();
    }

    public class DataContainer
    {
        [JsonPropertyName("sportId")]
        public int SportId { get; set; }

        [JsonPropertyName("config")]
        public Config Config { get; set; } = new();

        [JsonPropertyName("teams")]
        public List<Team> Teams { get; set; } = new();

        [JsonPropertyName("startTime")]
        public string StartTime { get; set; } = string.Empty;

        [JsonPropertyName("league")]
        public League League { get; set; } = new();

        [JsonPropertyName("insights")]
        public List<Insight> Insights { get; set; } = new();
    }

    public class Config
    {
        [JsonPropertyName("availableTabs")]
        public List<string> AvailableTabs { get; set; } = new();

        [JsonPropertyName("dateTimeFormatConfig")]
        public DateTimeFormatConfig DateTimeFormatConfig { get; set; } = new();
    }

    public class DateTimeFormatConfig
    {
        [JsonPropertyName("shortDate")]
        public string ShortDate { get; set; } = string.Empty;

        [JsonPropertyName("shortTime")]
        public string ShortTime { get; set; } = string.Empty;

        [JsonPropertyName("shortDateNoYear")]
        public string ShortDateNoYear { get; set; } = string.Empty;
    }

    public class Team
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("statistics")]
        public Statistics Statistics { get; set; } = new();
    }

    public class Statistics
    {
        [JsonPropertyName("form")]
        public TeamForm Form { get; set; } = new();

        [JsonPropertyName("items")]
        public List<StatItem> Items { get; set; } = new();
    }

    public class TeamForm
    {
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("values")]
        public List<FormValue> Values { get; set; } = new();
    }

    public class FormValue
    {
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;

        [JsonPropertyName("type")]
        public int Type { get; set; }
    }

    public class StatItem
    {
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;

        [JsonPropertyName("stat")]
        public int StatId { get; set; }

        [JsonPropertyName("highlight")]
        public bool Highlight { get; set; }

        [JsonPropertyName("information")]
        public string? Information { get; set; }
    }

    public class League
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }

    public class Insight
    {
        [JsonPropertyName("text")]
        public string Text { get; set; } = string.Empty;

        [JsonPropertyName("locale")]
        public string Locale { get; set; } = string.Empty;

        [JsonPropertyName("marketTypes")]
        public List<MarketType> MarketTypes { get; set; } = new();
    }

    public class MarketType
    {
        [JsonPropertyName("specifierTypeId")]
        public int? SpecifierTypeId { get; set; }

        [JsonPropertyName("specifierValue")]
        public double? SpecifierValue { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }

    public class QualifiedMarketsContainer
    {
        [JsonPropertyName("qualificados")]
        public List<QualifiedMarket> Qualificados { get; set; } = new();
    }

    public class QualifiedMarket
    {
        [JsonPropertyName("mercado")]
        public string Mercado { get; set; } = string.Empty;

        [JsonPropertyName("prob")]
        public double Prob { get; set; }
    }

    public class MatchAnalysis
    {
        [JsonPropertyName("jogo")]
        public string Jogo { get; set; } = string.Empty;

        [JsonPropertyName("campeonato")]
        public string Campeonato { get; set; } = string.Empty;

        [JsonPropertyName("data")]
        public string Data { get; set; } = string.Empty;

        [JsonPropertyName("resumo_lesoes")]
        public string ResumoLesoes { get; set; } = string.Empty;

        [JsonPropertyName("raciocinio")]
        public string Raciocinio { get; set; } = string.Empty;

        [JsonPropertyName("historico_gols")]
        public HistoricoGols HistoricoGols { get; set; } = new();

        [JsonPropertyName("probabilidades")]
        public List<QualifiedMarket> Probabilidades { get; set; } = new();

        [JsonPropertyName("qualificados")]
        public List<QualifiedMarket> Qualificados { get; set; } = new();

        [JsonPropertyName("debug_calculo")]
        public DebugCalculo DebugCalculo { get; set; } = new();
    }

    public class HistoricoGols
    {
        [JsonPropertyName("time_a")]
        public double TimeA { get; set; }

        [JsonPropertyName("time_b")]
        public double TimeB { get; set; }
    }

    public class DebugCalculo
    {
        [JsonPropertyName("lambda_time_a")]
        public double LambdaTimeA { get; set; }

        [JsonPropertyName("lambda_time_b")]
        public double LambdaTimeB { get; set; }
    }
}
