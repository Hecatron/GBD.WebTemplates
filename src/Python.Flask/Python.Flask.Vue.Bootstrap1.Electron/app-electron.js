const {app, BrowserWindow} = require('electron')
const portfinder = require('portfinder');
const {PythonShell} = require('python-shell');

  function startpython (portnumber) {
    // Start flask / python
    console.log("Starting python on port: " + portnumber);
    let options = {
      args: [portnumber]
    };
    PythonShell.run('app.py', options, function  (err, results)  {
      if  (err)  console.log(err);
      });
  }

  function startbrowser (portnumber) {
    window = new BrowserWindow({width: 800, height: 600})
    // Hide the top menu
    window.setMenu(null);
    // Load the site from flask
    window.loadURL('http://127.0.0.1:' + portnumber + '/')
  }

  function createWindow () {
    portfinder.basePort = 5000
    portfinder.getPort(function (err, port) {
      startpython(port);
      startbrowser(port);
    });
  }

  // Create the window on ready event
  app.on('ready', createWindow)

  app.on('window-all-closed', () => {
    // On macOS it is common for applications and their menu bar
    // to stay active until the user quits explicitly with Cmd + Q
    if (process.platform !== 'darwin') {
      app.quit()
    }
  })

