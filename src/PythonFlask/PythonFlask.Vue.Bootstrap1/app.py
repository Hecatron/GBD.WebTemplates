import sys
import re
from datetime import datetime
from flask import Flask

app = Flask(__name__, static_folder='wwwroot')

@app.route("/")
def hello():
    return "Hello World from Flask!"


@app.route("/hello/<name>")
def hello_there(name):
    now = datetime.now()
    formatted_now = now.strftime("%A, %d %B, %Y at %X")

    # Filter the name argument to letters only using regular expressions. URL arguments
    # can contain arbitrary text, so we restrict to safe characters only.
    match_object = re.match("[a-zA-Z]+", name)

    if match_object:
        clean_name = match_object.group(0)
    else:
        clean_name = "Friend"

    content = "Hello there, " + clean_name + "! It's " + formatted_now
    return content


# Needed for electron / launching directly
if __name__ == "__main__":
    # Get the port number if specified
    portnum = 5000
    if len(sys.argv) >= 2:
        portnum = sys.argv[1]
    app.run(host='127.0.0.1', port=portnum)
