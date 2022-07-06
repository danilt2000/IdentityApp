using Microsoft.AspNetCore.Identity;
using IdentityApp.Models;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace IdentityApp.Authorization
{
    public class InvoiceCreatorAuthorizationHandler :
        AuthorizationHandler<OperationAuthorizationRequirement,Invoice>
    {
        UserManager<IdentityUser> _userManager;


        public  InvoiceCreatorAuthorizationHandler(UserManager<IdentityUser>userManager)
        {
            _userManager = userManager;


        }

        protected override Task HandleRequirementAsync(
            AuthorizationHandlerContext context, 
            OperationAuthorizationRequirement requirement, 
            Invoice invoice)
        {
            if (context.User == null || invoice == null)
                return Task.CompletedTask;


            if (requirement.Name!= Constants.CreateOpetationName &&
                requirement.Name!=Constants.ReadOpetationName &&
                requirement.Name!=Constants.UpdateOpetationName &&
                requirement.Name!=Constants.DeleteOpetationName)

            {
                return Task.CompletedTask;
            }

            if (invoice.CreatorId == _userManager.GetUserId(context.User))
                context.Succeed(requirement);


            return Task.CompletedTask;
           
        }
    }
}
