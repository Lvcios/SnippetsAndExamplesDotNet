using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    public class Robot
    {
        public Body _body { get; set; }
        public Robot()
        {
            _body = new Body();
        }

        public void Caminar()
        {
            if(_body != null)
            {
                _body.Caminar();
            }
        }

        public void Disparar()
        {
            if (_body != null)
            {
                _body.Disparar();
            }
        }

        public void Volar()
        {
            if (_body != null)
            {
                _body.Volar();
            }
        }

        public void BuscarAJhonConnor()
        {

        }
    }
}
