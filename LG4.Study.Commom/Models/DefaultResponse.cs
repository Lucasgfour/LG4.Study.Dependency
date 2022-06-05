using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Study.Commom.Models {
    public class DefaultResponse<Model> {

        public bool condition { get; set; }
        public string message { get; set; } = "";
        public Model? response { get; set; }

        public DefaultResponse(bool condition, string message) {
            this.condition = condition;
            this.message = message;
        }

        public DefaultResponse(bool condition, Model response) {
            this.condition = condition;
            this.response = response;
        }

        public DefaultResponse(bool condition, string message, Model? response) {
            this.condition = condition;
            this.message = message;
            this.response = response;
        }

    }
}
