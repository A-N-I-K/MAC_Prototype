#include <iostream>
#include <fstream>
#include <string>

using namespace std;

const int COLUMNS = 5;

class User {
public:
	string fname;
	string lname;
	string uid;
	string pwd;
	string role;
};

int main()
{
	//cout << "This is a test!" << endl;
	ifstream myReadFile;
	myReadFile.open("user.db");
	char output[100];
	if (myReadFile.is_open()) {
		while (!myReadFile.eof()) {
			myReadFile >> output;
			cout << output << endl;
		}
	}
	else {
		cout << "File not found!" << endl;
	}
	myReadFile.close();
	system("pause");
	return 0;
}

User authUser(string uid, string pwd) {
	User newuser;
	return newuser;
}