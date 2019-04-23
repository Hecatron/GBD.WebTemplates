declare global {
  interface Window {
    eel: any
  }
}


// Point Eel web socket to the instance
export const eel = window.eel
eel.set_host('ws://localhost:8080')


// Expose the `sayHelloJS` function to Python as `say_hello_js`
function sayHelloJS(x: any) {
  console.log('Hello from ' + x)
}

// WARN: must use window.eel to keep parse-able eel.expose{...}
window.eel.expose(sayHelloJS, 'say_hello_js')

sayHelloJS('Javascript1')
eel.say_hello_py('Javascript2')
