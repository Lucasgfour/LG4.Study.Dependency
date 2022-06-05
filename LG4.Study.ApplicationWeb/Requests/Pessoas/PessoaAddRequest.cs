namespace LG4.Study.ApplicationWeb.Requests.Pessoas {
    public class PessoaAddRequest {

        public string name { get; set; } = "";
        public string email { get; set; } = "";
        public string phone { get; set; } = "";

        public PessoaAddRequest() { }

        public PessoaAddRequest(string name, string email, string phone) {
            this.name = name;
            this.email = email;
            this.phone = phone;
        }
    }
}
