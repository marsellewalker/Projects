#pragma once
#include <iostream>
#include <string>
#include <thread>
#include<chrono>
using namespace std; 
using namespace std::this_thread;

using namespace std::chrono;

   
 string Enter = "";
 void m()
  {
    do {
         cout << "Press ENTER to start Launch from main space base\n Target Rocket Pad" << std::endl;
         getline(cin, Enter);
       } while (Enter.length() != 0);
   }
    
    void l(string y)
    {
        for (int i = 1; i < 11; i++)
        { 
            
            cout << "Launching:  " << y <<i<< endl;
            
            if (i == 2)
            {
                cout << " abort To stop space Cadet Launch of missiles at Rocket pad\n fire to continue Launching."<<endl;
                string b;
                printf("----------------------------------------------------------\n");
                printf("What would you like to do Commander\n");
                printf("Commander: ");
                cin >> b;
                printf("----------------------------------------------------------\n");
               
                if (b=="abort") {
                    cout << "!!!Aborting,Aborting!!!\n" << "Rocket # " << i<<" Has been Aborted,"<< " mission has been scrubed\n";
                    printf("----------------------------------------------------------\n");
                    break;
                }
                else if(b=="fire") {
                    this_thread::sleep_for(3000ms); //Telling the thread to sleep for 3 seconds to simulate artificial time passing doing processing work.
                   
                    cout << "Rocket Pad Space Cadet \n"; continue; }
                
            }
            if (i == 3)
            {
                cout << " abort To stop space Cadet Launch of missiles at Rocket pad\n fire to continue Launching." << endl;
                string b;
                printf("----------------------------------------------------------\n");
                printf("What would you like to do Commander\n");
                printf("Commander: ");
                cin >> b;
                printf("----------------------------------------------------------\n");

                if (b == "abort") {
                    cout << "!!!Aborting,Aborting!!!\n" << "Rocket # " << i << " Has been Aborted," << " mission has been scrubed\n";
                    printf("----------------------------------------------------------\n");
                    break;
                }
                else if (b == "fire") {
                    this_thread::sleep_for(3000ms); //Telling the thread to sleep for 3 seconds to simulate artificial time passing doing processing work.

                    cout << "Rocket Pad Space Cadet \n"; continue;
                }
            }
            if (i == 4)
            {
                cout << " abort To stop space Cadet Launch of missiles at Rocket pad\n fire to continue Launching." << endl;
                string b;
                printf("----------------------------------------------------------\n");
                printf("What would you like to do Commander\n");
                printf("Commander: ");
                cin >> b;
                printf("----------------------------------------------------------\n");

                if (b == "abort") {
                    cout << "!!!Aborting,Aborting!!!\n" << "Rocket # " << i << " Has been Aborted," << " mission has been scrubed\n";
                    printf("----------------------------------------------------------\n");
                    break;
                }
                else if (b == "fire") {
                    this_thread::sleep_for(3000ms); //Telling the thread to sleep for 3 seconds to simulate artificial time passing doing processing work.

                    cout << "Rocket Pad Space Cadet \n"; continue;
                }
            }
            if (i == 5)
            {
                cout << " abort To stop space Cadet Launch of missiles at Rocket pad\n fire to continue Launching." << endl;
                string b;
                printf("----------------------------------------------------------\n");
                printf("What would you like to do Commander\n");
                printf("Commander: ");
                cin >> b;
                printf("----------------------------------------------------------\n");

                if (b == "abort") {
                    cout << "!!!Aborting,Aborting!!!\n" << "Rocket # " << i << " Has been Aborted," << " mission has been scrubed\n";
                    printf("----------------------------------------------------------\n");
                    break;
                }
                else if (b == "fire") {
                    this_thread::sleep_for(3000ms); //Telling the thread to sleep for 3 seconds to simulate artificial time passing doing processing work.

                    cout << "Rocket Pad Space Cadet \n"; continue;
                }
            }
            if (i == 6)
            {
                cout << " abort To stop space Cadet Launch of missiles at Rocket pad\n fire to continue Launching." << endl;
                string b;
                printf("----------------------------------------------------------\n");
                printf("What would you like to do Commander\n");
                printf("Commander: ");
                cin >> b;
                printf("----------------------------------------------------------\n");

                if (b == "abort") {
                    cout << "!!!Aborting,Aborting!!!\n" << "Rocket # " << i << " Has been Aborted," << " mission has been scrubed\n";
                    printf("----------------------------------------------------------\n");
                    break;
                }
                else if (b == "fire") {
                    this_thread::sleep_for(3000ms); //Telling the thread to sleep for 3 seconds to simulate artificial time passing doing processing work.

                    cout << "Rocket Pad Space Cadet \n"; continue;
                }
            }
            if (i == 7)
            {
                cout << " abort To stop space Cadet Launch of missiles at Rocket pad\n fire to continue Launching." << endl;
                string b;
                printf("----------------------------------------------------------\n");
                printf("What would you like to do Commander\n");
                printf("Commander: ");
                cin >> b;
                printf("----------------------------------------------------------\n");

                if (b == "abort") {
                    cout << "!!!Aborting,Aborting!!!\n" << "Rocket # " << i << " Has been Aborted," << " mission has been scrubed\n";
                    printf("----------------------------------------------------------\n");
                    break;
                }
                else if (b == "fire") {
                    this_thread::sleep_for(3000ms); //Telling the thread to sleep for 3 seconds to simulate artificial time passing doing processing work.

                    cout << "Rocket Pad Space Cadet \n"; continue;
                }
            }
            if (i == 8)
            {
                cout << " abort To stop space Cadet Launch of missiles at Rocket pad\n fire to continue Launching." << endl;
                string b;
                printf("----------------------------------------------------------\n");
                printf("What would you like to do Commander\n");
                printf("Commander: ");
                cin >> b;
                printf("----------------------------------------------------------\n");

                if (b == "abort") {
                    cout << "!!!Aborting,Aborting!!!\n" << "Rocket # " << i << " Has been Aborted," << " mission has been scrubed\n";
                    printf("----------------------------------------------------------\n");
                    break;
                }
                else if (b == "fire") {
                    this_thread::sleep_for(3000ms); //Telling the thread to sleep for 3 seconds to simulate artificial time passing doing processing work.

                    cout << "Rocket Pad Space Cadet \n"; continue;
                }
            }
            if (i == 9)
            {
                cout << " abort To stop space Cadet Launch of missiles at Rocket pad\n fire to continue Launching." << endl;
                string b;
                printf("----------------------------------------------------------\n");
                printf("What would you like to do Commander\n");
                printf("Commander: ");
                cin >> b;
                printf("----------------------------------------------------------\n");

                if (b == "abort") {
                    cout << "!!!Aborting,Aborting!!!\n" << "Rocket # " << i << " Has been Aborted," << " mission has been scrubed\n";
                    printf("----------------------------------------------------------\n");
                    break;
                }
                else if (b == "fire") {
                    this_thread::sleep_for(3000ms); //Telling the thread to sleep for 3 seconds to simulate artificial time passing doing processing work.

                    cout << "Rocket Pad Space Cadet \n"; continue;
                }
            }
            if (i == 10)
            {
                cout << " abort To stop space Cadet Launch of missiles at Rocket pad\n fire to continue Launching." << endl;
                string b;
                printf("----------------------------------------------------------\n");
                printf("What would you like to do Commander\n");
                printf("Commander: ");
                cin >> b;
                printf("----------------------------------------------------------\n");

                if (b == "abort") {
                    cout << "!!!Aborting,Aborting!!!\n" << "Rocket # " << i << " Has been Aborted," << " mission has been scrubed\n";
                    printf("----------------------------------------------------------\n");
                    break;
                }
                else if (b == "fire") {
                    this_thread::sleep_for(3000ms); //Telling the thread to sleep for 3 seconds to simulate artificial time passing doing processing work.

                    cout << "Rocket Pad Space Cadet: That was our last missile sir.\nAll launches were succesful.\n Seven out of ten hit.\n"; continue;
                }
            }


          
            this_thread::sleep_for(3000ms); //Telling the thread to sleep for 3 seconds to simulate artificial time passing doing processing work.
            printf("----------------------------------------------------------\n");
            cout << "Rocket Pad Space Cadet \n";
        }
    }

    void talk()
    {
        printf("----------------------------------------------------------\n");
        printf("Everything is in chaos, we are at war, what should we do\n");
        printf("Ustaf is Mounting an Attack on us.\n");
        printf("What would you like to do Commander.\n");
        printf("----------------------------------------------------------\n");
        printf("Commander: Prepare the missles for launch\n");
        printf("We need to protect what is ours.\n");
        printf("----------------------------------------------------------\n");   
   }

    
   
  