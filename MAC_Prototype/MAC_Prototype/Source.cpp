#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
	//cout << "This is a test!" << endl;
	ifstream myReadFile;
	myReadFile.open("user.db");
	char output[100];
	if (myReadFile.is_open()) {
		while (!myReadFile.eof()) {


			myReadFile >> output;
			cout << output;


		}
	}
	myReadFile.close();
	return 0;
}