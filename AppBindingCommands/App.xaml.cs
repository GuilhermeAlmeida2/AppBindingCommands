﻿namespace AppBindingCommands;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		DateTime data = DateTime.Now;
		Preferences.Set("dtAtual", data);
		Preferences.Set("AcaoInicial", string.Format("* App execultado às {0}. \n", data));
		MainPage = new AppShell();
	}

    protected override void OnStart()
    {
        base.OnStart();
		Preferences.Set("AcaoStart", string.Format("* App iniciada às {0}. \n", DateTime.Now));
	}

    protected override void OnSleep()
    {
        base.OnSleep();
        Preferences.Set("AcaoSleep",string.Format("* App em segundo pleno às {0}. \n",DateTime.Now));
    }

    protected override void OnResume()
    {
        base.OnResume();
        Preferences.Set("AcaoResume",string.Format("* App reativo às {0}. \n",DateTime.Now));
    }
}
