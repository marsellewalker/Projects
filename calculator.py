from tkinter import *
 
# Makes calculator frame
def framee(source, side):
    storeObj = Frame(source, borderwidth=4, bd=4, bg="red")
    storeObj.pack(side=side, expand =YES, fill =BOTH)
    return storeObj
 
# makes Button
def button(source, side, text, command=None):
    storeObj = Button(source, text=text, command=command)
    storeObj.pack(side=side, expand = YES, fill=BOTH)
    return storeObj
 


#the class that allows the buttons and display to be created
class app(Frame):
    def __init__(self):
        Frame.__init__(self)
        self.option_add('*Font', 'arial 20 bold')
        self.pack(expand = YES, fill =BOTH)
        self.master.title('Solution')

        display = StringVar()
 
        Entry(self, relief=RIDGE, textvariable=display,justify='right', bd=30, bg="red").pack(side=TOP,expand=YES, fill=BOTH)

        #Erases the numbers put in to the frame
        for clear in (["E"]):
            delete = framee(self, TOP)
            for ichar in clear:
                button(delete, LEFT, ichar, lambda
                    storeObj=display, q=ichar: storeObj.set(''))
       
       # The way calculators should have always been made.
        for buttons in ("0.+","123-","456*","789/"):
         buttonF = framee(self, TOP)
         for l in buttons:
            button(buttonF, LEFT, l, lambda
                storeObj=display, q=l: storeObj
                   .set(storeObj.get() + q))
            
        # this adds a functional equals button and them button
        solve = framee(self, TOP)
        for l in "=":
            if l == '=':
                btniEquals = button(solve, LEFT, l)
                btniEquals.bind('<ButtonRelease-1>', lambda e,s=self,
                                storeObj=display: s.calc(storeObj), '+')
                                                         
            else:
                btniEquals = button(solve, LEFT, l,
                                    lambda storeObj=display, s=' %s ' % l: storeObj.set
                                    (storeObj.get() + s))
 
    #Triggers for the buttons
    def calc(self, display):
            try:
                display.set(eval(display.get()))
            except:
                display.set("ERROR")
  

# start up the graphics fpr the calculator
if __name__=='__main__':
 app().mainloop()

 
 

