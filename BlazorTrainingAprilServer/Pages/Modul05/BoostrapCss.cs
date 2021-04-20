using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTrainingAprilServer.Pages.Modul05
{
    public class BoostrapCss : FieldCssClassProvider
    {
        public override string GetFieldCssClass(EditContext editContext, in FieldIdentifier fieldIdentifier)
        {
          var isValid= !editContext.GetValidationMessages(fieldIdentifier).Any();

            return isValid?"is-valid":"is-invalid" ;
        }
    }
}
