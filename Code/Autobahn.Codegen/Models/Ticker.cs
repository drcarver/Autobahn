namespace Autobahn.Codegen.Models
{
    /// <summary>
    /// Companies from FMP
    /// </summary>
    [Table("Ticker", Schema = "StockPortfolio")]
    internal class Ticker
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [JsonProperty("name")]
        [MaxLength(130, ErrorMessage = "{0} must be less then {1} characters")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        [MaxLength(20, ErrorMessage = "{0} must be less then {1} characters")]
        public string Symbol { get; set; }

        [JsonProperty("price")]
        [Required(ErrorMessage="{0} is required")]
        public double Price { get; set; }

        [JsonProperty("exchange")]
        [MaxLength(40, ErrorMessage = "{0} must be less then {1} characters")]
        public string Exchange { get; set; }

        [JsonProperty("exchangeShortName")]
        [MaxLength(20, ErrorMessage = "{0} must be less then {1} characters")]
        public string ExchangeShortName { get; set; }

        [JsonProperty("type")]
        public string TickerType { get; set; }
    }
}

