using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AutenticacionPersonalizada.Seguridad
{
    public class PrincipalPersonalizado:IPrincipal
    {
        public bool IsInRole(string role)
        {
            return MiIdentityPersonalizado.Rol == role;
        }
        //Con polimorfismo y al definir private set, hacemos que IIdentity almacene datos
        //forzando que IIdentity sea IdentityPersonalizado
        public IIdentity Identity { get; private set; }

        public IdentityPersonalizado MiIdentityPersonalizado
        {
            get { return (IdentityPersonalizado) Identity; }
            set { Identity = value; }
        }

        //Constructor
        public PrincipalPersonalizado(IdentityPersonalizado identity)
        {
            Identity = identity;
        }

    }
}
