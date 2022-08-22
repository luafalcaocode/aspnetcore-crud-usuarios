using luafalcao.api.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace luafalcao.api.Domain.Validations
{
    public class UsuarioValidationsSingleton
    {
        private static UsuarioValidationsSingleton _instance = new UsuarioValidationsSingleton();

        private IList<string> _validacoes;

        private UsuarioValidationsSingleton()
        {

        }

        public static UsuarioValidationsSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new UsuarioValidationsSingleton();
            }

            return _instance;
        }

        public IList<string> Validar(Usuario usuario)
        {
            _validacoes = new List<string>();

            return _validacoes;
        }
    }
}
