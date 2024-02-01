using System.Collections;
using System.Collections.Generic;
using Zenject;

public class MyInstaller : Installer<MyInstaller>
{
    public override void InstallBindings()
    {
        Container.Bind<RegularInstallerTestClass>().AsSingle();
    }
}