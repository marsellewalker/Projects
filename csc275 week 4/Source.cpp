#include <iostream>
#include "Header.h"
#include <string>
#include <thread>
#include<chrono>
using namespace std;


int main() {


	string f = "Rocket # ";

	
	thread story(talk);
	if (story.joinable())
	{
		story.join();
	}
	



	thread open(m);
	if (open.joinable())
	{
		open.join();
	}



	thread action(l,f);
	if (action.joinable())
	{
		action.join();
	}
	
	
	
	return 0;
}