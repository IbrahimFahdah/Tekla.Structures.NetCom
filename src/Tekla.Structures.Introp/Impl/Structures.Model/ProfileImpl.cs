using System.Runtime.InteropServices;
using Tekla.Introp.Contracts.Structures.Model;
using Tekla.Structures.Introp.Helpers;
using Tekla.Structures.Model;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public class ProfileImpl : TkObjWrapper, IProfile
    {
        private Profile TkProfile => (Profile)TKObj;

        public ProfileImpl(Profile profile) : base(profile)
        {
        }

        public string ProfileString
        {
            get => TkProfile.ProfileString;
            set => TkProfile.ProfileString = value;
        }
    }
}