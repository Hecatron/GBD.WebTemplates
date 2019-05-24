# Chromely Templates

Chromley is a .Net library that ties into CefSharp / CefGlue, it uses chrome to launch a GUI.
This is similar to Electron .Net but seems to use less memory and seems to be a bit faster to launch.
Recently subprocess support has been added making it compatible with debugging under .net core.

At the time of writing this hasn't been released as a specific version yet
so I've put some pre-built .Net dll libs under libs\Chromely

One of the things needed by Chromley is the files from libcef
By default libcef is included for windows with the nuget package but not while debugging the library directly
or I think for linux platforms.
That being said there does seem to be an automated system to download libcef when the lib is launched and the libcef files are not detected.

## Downloading the libcef files

### Using the libcef downloader

To manually download the libcef files
To download the libcef file downloader
```
git clone https://github.com/chromelyapps/cef-binaries-downloader.git
cd cef-binaries-downloader\binaries\net
```

At the time of writing chromely is using version **3.3538.1852.gcb937fc** of libcef
To download the libcef binaries for windows
```
chromelycef.exe download --cef-binary-version=3.3538.1852.gcb937fc -c=x64 --os="win" -d="bin\win-x64"
```

For Linux
```
chromelycef.exe download --cef-binary-version=3.3538.1852.gcb937fc -c=x64 --os="linux" -d="bin\linux-x64"
```

### Manual downloading

  * http://opensource.spotify.com/cefbuilds/index.html
  * https://www.spotify.com/uk/opensource/
  * CEF 3.3538.1852.gcb937fc / Chromium 70.0.3538.102
  * minimal version

The files we're interesed in includes:
```
*.pak
*.bin
*.dat
locales/
chrome_elf.dll
libcef.dll
libEGL.dll
libGLESv2.dll
```

## Rpi support

In order to get Rpi support working we need a build of libcef for ArmV7
this may be arriving soon via official builds
If we can build libcef for the Armv7 then we may be able to use Chromley for the Rpi3

  * https://bitbucket.org/chromiumembedded/cef/issues/1990/linux-add-arm-build-support

.Net core is supported on the Armv7 platform (which includes the Rpi2 / Rpi3)
but not the Armv6 (rpi1 / Rpi zero)
