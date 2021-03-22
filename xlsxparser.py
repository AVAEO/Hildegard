import sys
import requests
import time

fileName = sys.argv[1]

with open("text.txt","w") as f:
    f.write(fileName + "\n")
    for i in range(10):
        f.write(str(i) + "\n")
    #end if
#end with

url = 'https://localhost:5001/teacher/uploadhook'
#headers = {'Content-type': "text/plain"}
time.sleep(5)
req = requests.post(url, data = {"name":"success"}, verify=False)
print(req)

