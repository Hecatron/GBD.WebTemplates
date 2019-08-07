declare global {
  interface Eel {
    set_host(hostname: string): void;
    expose(f: Function, name: string): void;
    guid(): string;
  }

  interface Window {
    eel: Eel;
  }
}


// Point Eel web socket to the instance
export const eel = window.eel
// The list of python functions hasn't been defined yet so use an any type for callbacks
export const eelpy = <any> eel;

eel.set_host('ws://localhost:8080')


// Expose the `sayHelloJS` function to Python as `say_hello_js`
function sayHelloJS(x: string) {
  console.log('Hello from ' + x)
}

// WARN: must use window.eel to keep parse-able eel.expose{...}
window.eel.expose(sayHelloJS, 'say_hello_js')

sayHelloJS('Javascript1')
eelpy.say_hello_py('Javascript2')
