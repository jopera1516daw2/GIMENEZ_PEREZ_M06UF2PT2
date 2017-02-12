using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIMENEZ_PEREZ_M06UF2PT2.Interface{
    /// <summary>
    /// Clase que tiene los datos de la sesión activa
    /// </summary>
    class Config {
        public string currentUser;
        public string currentDireccion;
        private static Config instance;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <returns></returns>
        public static Config getInstance(){
            if (instance == null){
                instance = new Config();
            }
            return instance;
        }
    }
}
