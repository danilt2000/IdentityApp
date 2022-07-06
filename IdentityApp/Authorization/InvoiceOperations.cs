using Microsoft.AspNetCore.Authorization.Infrastructure;



namespace IdentityApp.Authorization
{
    public class InvoiceOperations
    {
        public static OperationAuthorizationRequirement Create =
            new OperationAuthorizationRequirement{ Name = Constants.CreateOpetationName };

         public static OperationAuthorizationRequirement Read =
            new OperationAuthorizationRequirement{ Name = Constants.ReadOpetationName };

         public static OperationAuthorizationRequirement Update =
            new OperationAuthorizationRequirement{ Name = Constants.UpdateOpetationName };

         public static OperationAuthorizationRequirement Delete =
            new OperationAuthorizationRequirement{ Name = Constants.DeleteOpetationName };

         public static OperationAuthorizationRequirement Approved =
            new OperationAuthorizationRequirement{ Name = Constants.ApprovedOperationName };

         public static OperationAuthorizationRequirement Rejected =
            new OperationAuthorizationRequirement{ Name = Constants.RejectedOperationName };



    }

    public class Constants
    {

        public static readonly string CreateOpetationName = "Create";
        public static readonly string ReadOpetationName = "Read";
        public static readonly string UpdateOpetationName = "Update";
        public static readonly string DeleteOpetationName = "Delete";

        public static readonly string ApprovedOperationName = "Approved";
        public static readonly string RejectedOperationName = "Rejected";


    }


}
