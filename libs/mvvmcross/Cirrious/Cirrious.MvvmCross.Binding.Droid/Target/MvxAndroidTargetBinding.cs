// MvxAndroidTargetBinding.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using Cirrious.CrossCore.Droid;
using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.Binding.Bindings.Target;

namespace Cirrious.MvvmCross.Binding.Droid.Target
{
    public abstract class MvxAndroidTargetBinding
        : MvxTargetBinding
    {
        private IMvxAndroidGlobals _androidGlobals;

        protected MvxAndroidTargetBinding(object target)
            : base(target)
        {
        }

        protected IMvxAndroidGlobals AndroidGlobals
        {
            get
            {
                if (_androidGlobals == null)
                    _androidGlobals = Mvx.Resolve<IMvxAndroidGlobals>();
                return _androidGlobals;
            }
        }
    }
}