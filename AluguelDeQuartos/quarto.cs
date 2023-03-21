using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelDeQuartos {
    internal class Quarto {
        private int _id = 0;
        private string _name = "";
        private string _email = "";
        private int _room = 0;

        public Quarto(int id, string name, string email, int room) {
            _id = id;
            _name = name;
            _email = email;
            _room = room;
        }
        public void GetQuarto() {
            Console.WriteLine($"Quartos Ocupados: \n" +
                $"Aluguel #{_id}:\n" +
                $"Name: {_name}\n" +
                $"Email: {_email}\n" +
                $"Quarto: {_room}");
        }
    }
}
