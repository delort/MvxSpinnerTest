// Plugin.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using Cirrious.CrossCore.IoC;
using Cirrious.CrossCore.Plugins;

namespace Cirrious.MvvmCross.Plugins.SoundEffects.WindowsPhone
{
    public class Plugin
        : IMvxPlugin          
    {
        public void Load()
        {
#warning One day I would like to decouple this implementation from the ResourceLoader plugin
            ResourceLoader.PluginLoader.Instance.EnsureLoaded();

            Mvx.RegisterType<IMvxSoundEffectLoader, MvxSoundEffectObjectLoader>();
        }
    }
}