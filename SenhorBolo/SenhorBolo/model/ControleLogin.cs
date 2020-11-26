using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SenhorBolo.dao;


namespace SenhorBolo.model
{
    public class ControleLogin
    {
        public bool Acesso;

        public bool Acessar(int userType, string login, String senha) {
            LoginDAO loginDao = new LoginDAO();
            Acesso = loginDao.Acessar(userType, login, senha);
            return Acesso;
        }
    }
}
