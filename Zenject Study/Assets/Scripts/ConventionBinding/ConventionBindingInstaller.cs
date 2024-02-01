using System.Collections;
using System.Collections.Generic;
using Zenject;

public class ConventionBindingInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind(binder => binder.AllClasses().WithPrefix("Convention")).AsSingle();
    }
}