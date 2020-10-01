# OpenRA Tileset Builder

Open indexed PNG files and export them into Westwood 2D terrain tile files.

![Screenshot](https://camo.githubusercontent.com/0194457c97c9cd10be75cb7be8f62135f4238a55/687474703a2f2f692e696d6775722e636f6d2f33437538392e706e67)

More info on this wiki page: https://github.com/OpenRA/TilesetBuilder/wiki

## Build instructions

Enter those commands in a command line:
```
git submodule init
git submodule update
cd OpenRA
make all
cd ..
make
```

If you don't use git, put engine version `8596ce00cc27c3cc2ee4cd899465793ab7b5faa0` inside the "OpenRA" folder.
Then build the engine and run the `make` command in the TilesetBuilder directory.
