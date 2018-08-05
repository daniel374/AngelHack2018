from django.shortcuts import render
import pyrebase
# Create your views here.

config = {
    'apiKey': "AIzaSyDgsgVByuw6_CFUOBAGVuBUuWaLp5DQEzg",
    'authDomain': "hackprojec2018.firebaseapp.com",
    'databaseURL': "https://hackprojec2018.firebaseio.com",
    'projectId': "hackprojec2018",
    'storageBucket': "hackprojec2018.appspot.com",
    'messagingSenderId': "995968370254"
    }

firebase = pyrebase.initialize_app(config)

auth = firebase.auth()

def singIn(request):
    
    return render(request, "signIn.html")

def postsign(request):
    email=request.POST.get('email')
    passwd=request.POST.get("pass")

    try:
	user = auth.sign_in_with_email_and_password(email,passwd)
    except:
        message = "invalid cerediantials"
    return render(request,"signIn.html",{"msg":message})
   
    return render(request, "welcome.html",{"e":email})
