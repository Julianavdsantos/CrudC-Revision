using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransactions.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName ="nvarchar(12)")]
        [DisplayName("Número de conta")]

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(12,ErrorMessage ="Maximum 12 characters only.")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Nome do Beneficiário")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Nome do banco")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("Código ")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(11, ErrorMessage = "Maximum 11 characters only.")]
        public string SWIFTCode { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Valor ")]
        public int Amount { get; set; }

        [DisplayFormat(DataFormatString ="{0:MMM-dd-yy}")]
        [DisplayName("Data ")]
        public DateTime Date { get; set; }
    }
}
