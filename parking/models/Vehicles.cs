using System;

namespace parking.models
{
    public class Veiculo
    {   
        public string Placa { get; set; } 
        public DateTime HoraEntrada { get; set; }

        public Veiculo(string placa) 
        {
            Placa = placa;
            // Registra a data e hora atuais no momento da criação do veículo.
            HoraEntrada = DateTime.Now;
        }
    }
    
}