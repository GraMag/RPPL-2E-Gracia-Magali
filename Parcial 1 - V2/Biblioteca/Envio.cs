using Biblioteca.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Envio
    {
        private double distancia;
        private EEnvio envioTipo;
        private double costoDeEnvio;
        private int idVenta;
        
        public Envio()
        {
            Distancia = Distancia;
            this.costoDeEnvio = 0;
        }

        public double CostoDeEnvio
        {
            get { return costoDeEnvio; }
            set 
            { 
                if(envioTipo == EEnvio.Moto)
                {
                    costoDeEnvio = 300 + distancia * 0.2 + value * 0.01; 
                }
                else
                {
                    costoDeEnvio = 500 + distancia * 0.5 + value * 0.05;
                }
            }
        }

        public EEnvio EnvioTipo
        {
            get { return envioTipo; }
            set { envioTipo = value; }
        }

        public double Distancia
        {
            get
            {
                return distancia;
            }
            set 
            {
                Random random = new Random();
                distancia = random.Next(1,1000); 
            }
        }

        public int IdVenta
        {
            get
            {
                return idVenta;
            }
            set
            {
                idVenta = value;
            }
        }

        public double CalcularEnvio(List<Producto> productos)
        {
            if(Distancia > 200)
            {
                EnvioTipo = EEnvio.Flete;
            }
            else
            {
                int totalProductos = 0;
                foreach (Producto item in productos)
                {
                    if (item.Cantidad > 10 || item.ECategoriaProp == Enum.ECategoria.CAMAS || totalProductos > 50)
                    {
                        this.EnvioTipo = EEnvio.Flete;
                        CostoDeEnvio = totalProductos;
                        return CostoDeEnvio;
                    }
                    totalProductos += item.Cantidad;
                    CostoDeEnvio = totalProductos;
                }
                this.EnvioTipo = EEnvio.Moto;
                CostoDeEnvio = totalProductos;
            }        
            return CostoDeEnvio;
        }
    }
}
