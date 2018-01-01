# [<img src="https://github.com/raicore/raicore/blob/master/assets/raicore.png?raw=true" height="16">](https://github.com/raicore) raicore-wallet

An Electron and dotnet core based wallet for easy, cross-platform, graphical use of raicore libraries
___

## Run / Build

Clone the repository:

```
$ git clone git@github.com:raicore/raicore-wallet.git
```

Restore donet and node packages:

```
$ dotnet restore
$ npm install
```

Run self-hosted:
```
$ dotnet build
$ dotnet run
```

Run inside Electron:
```
$ dotnet electronize start
```

Build for your environment:
```
$ dotnet electronize build
```

Build for other enviornments:
```
$ dotnet electronize build win
$ dotnet electronize build osx
$ dotnet electronize build linux
```

Add splash screen (use the one that matches your build):
```
$ npm run add-splash-win
$ npm run add-splash-osx
$ npm run add-splash-linux
```