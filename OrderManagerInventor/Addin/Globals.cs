
namespace OrderInvAddin.Addin
{
    public static class Globals
    {
        // Inventor application object.
        public static Inventor.Application invApp;

        // The unique ID for this add-in.  If this add-in is copied to create a new add-in
        // you need to update this ID along with the ID in the .manifest file, the .addin file
        // and create a new ID for the typelib GUID in AssemblyInfo.vb
        public const string g_simpleAddInClientID = "17A8FC6C-A98C-4FE0-85C9-4E3B19AF6642";

        public const string g_addInClientID = "{" + g_simpleAddInClientID + "}";
    }
}