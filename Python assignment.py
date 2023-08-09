import pyttsx3
import speech_recognition as sr

#import research_ass



#Get the different voice.

# This listens through your audio to respond back to you.

def listening ():
    

    # this will notice you're speaking 
    r = sr.Recognizer()



    # This opens the microphon on your computer for the speach reconition
    with sr.Microphone() as source:
        
       

        Speak('welcome, What would you like sir')
        #print('What would you like sir')
        #This will pause and wait for your responsem, this is the listing part
        r.pause_threshold = 0.5


        # This puts the audio into a variable
        Store_sounds = r.listen(source)


        try:
            #This lets you know that the api is listing by printing a statemnt
            #Speak("my ears are on a timer")
            
            print("my ears are on a timer")

            # use google api for voice reconition
            Query = r.recognize_google(Store_sounds)


            print("Did you say='", Query, "'")


        except Exception as e:
            print(e)
            #Speak("hold on sir")
            print("hold on sir")
            # returning 'there was an error' if an error happens.
            return "There was an error"
    # returns audio as text

    return Query
    

#Get the different voice.
engine = pyttsx3.init()
voice= engine.getProperty('voices')
print (voice)
engine.setProperty('voice', voice[1].id)


# This will allow your assistant to actually speak back to you. 
def Speak(audio):
  
    # Assigns pyttsx3 module
    engine = pyttsx3.init()


    # Everything passed to this will be spoken by assistant.
    engine.say(audio)
    engine.runAndWait()



if __name__ == '__main__':
    # this will communicate infinitely
    while True:
        command = listening()
        if "see you Friday" in command:
            Speak("Good by sir, It was a pleasure working with you")
            break
        
       # if "tuba" in command:
        #    Speak("Marselle walker Loves you more than, the sun can rise and the stars can shine, more than the mood will set and my heart will beat. you are my everything.")

        if "hey Friday" in command:
            Speak("Hello sir, how can i help you")

        if "what's my name" in command:
            Speak("Your name sir, your name is Iron man!") 
        
        if "what is AI" in command:
            Speak("Artificial intelligence (AI) is intelligence—perceiving, synthesizing, and inferring information—demonstrated by machines, as opposed to intelligence displayed by non-human animals and humans.") 
        
        if "what is technology" in command:
            Speak("the application of scientific knowledge for practical purposes, especially in industry. Technology is awesome!") 
        
        if "hello Friday" in command:
            Speak("Hello sir.") 
        if "why are they on a timer" in command:
            Speak("because you programed it that way, and its short, thats why i ask so many times hahahaha")

        
        