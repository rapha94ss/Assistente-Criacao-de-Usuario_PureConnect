using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriadorDeUsers
{
    class Usuario
    {
        public string Username { get; set; }
        public string PrimeiroNome { get; set; }
        public string Sobrenome { get; set; }
        public string DisplayName { get; set; }
        public int Extension { get; set; }
        public string DID { get; set; }
        public string Senha { get; set; }
        public string NetworkID { get; set; }
        public string MailBox { get; set; }
        public string Roles { get; set; }
        public string Workgroups { get; set; }
        public string StationName { get; set; }
        public string Location { get; set; }

        public Usuario() { }

    }
}
