using System.Collections;
using System.Collections.Generic;
using Zenject;

public class ScopeInstaller : MonoInstaller
{
    //Two instances will be created for three user
    public override void InstallBindings()
    {
        Container.Bind<ScopeClass>().AsCached();
        Container.Bind<ScopeClass>().WithId(typeof(ScopeClass)).AsCached();
    }
}