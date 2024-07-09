using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pc.Modelo
{
    public class Computador
    {
        private int Numeroserie;
        private string Marca;
        private string Tipo;
        private DateTime FechaCompra;
        private DateTime Garantia;
        private bool On_off;
        


        public Computador() { }

        public Computador(int Numeroserie, string Marca, string Tipo, DateTime FechaCompra, DateTime Garantia, bool On_off)
        {
            this.Numeroserie = Numeroserie;
            this.Marca = Marca;
            this.Tipo = Tipo;
            this.FechaCompra = FechaCompra;
            this.Garantia = Garantia;
            this.On_off = On_off;
        }
        public int getNserie(){return this.Numeroserie;}
        public void setNserie(int Numeroserie){this.Numeroserie = Numeroserie;}
        public string getMarca() { return this.Marca; }
        public void setMarca(string Marca) { this.Marca = Marca; }
        public string getTipo() { return this.Tipo; }
        public void setTipo(string Tipo){ this.Tipo = Tipo;}
        public DateTime getFechaCompra() {  return this.FechaCompra; }
        public void setFechaCompra(DateTime FechaCompra) { this.FechaCompra=FechaCompra; }
        public DateTime getGarantia() {  return this.Garantia; }
        public void setGarantia(DateTime Garantia) { this.Garantia = Garantia; }
        public bool getOn_off() {return this.On_off;}
        public void setOn_off(bool On_off) {this.On_off = On_off;}
    }

}
