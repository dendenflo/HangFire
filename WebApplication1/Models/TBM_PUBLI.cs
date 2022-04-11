using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class TBM_PUBLI
    {
        [Key]
        public int IDD_PUBLI { get; set; }

        public string NOM_PUBLI { get; set; }
        public bool EST_PUBLI { get; set; }
        public DateTime FEC_INICI { get; set; }
        public DateTime FEC_FINAL { get; set; }
        public int NUM_PUBLI { get; set; }
        public string COD_USUAR_REGIS { get; set; }
        public DateTime FEC_USUAR_REGIS { get; set; }
        public TimeSpan HOR_USUAR_REGIS { get; set; }
    }
}