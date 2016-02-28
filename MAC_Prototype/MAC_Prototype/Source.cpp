#include <iostream>
#include <fstream>
#include <string>

using namespace std;

const int COLUMNS = 5;

class User {
public:
	char fname[100];
	char lname[100];
	char uid[100];
	char pwd[100];
	char role[100];
	bool valid;
};

User authUser(char user[], char pass[]);
void listUser();
void addUser(User userObj);

int main()
{
	char user[100];
	char pass[100];
	char choice[100];
	User userObj;
	bool session;
	session = true;
	cout << "Please provide your username :" << endl;
	cin >> user;
	cout << "Please provide your password :" << endl;
	cin >> pass;
	userObj = authUser(user, pass);
	if (userObj.valid) {
		cout << "Welcome, " << userObj.fname << " " << userObj.lname << "!" << endl;
		while (session) {
			cout << "What would you like to do today?" << endl;
			cout << "1. List users" << endl;
			cout << "2. Add user" << endl;
			cout << "3. Modify user" << endl;
			cout << "4. Delete user" << endl;
			cout << "5. View log" << endl;
			cout << "6. Log out" << endl;
			cin >> choice;
			if (strcmp(choice, "1") == 0 || strcmp(choice, "One") == 0 || strcmp(choice, "one") == 0) {
				listUser();
			}
		}
	}
	else {
		cout << "Invalid username or password. This incident will be reported." << endl;
	}
	system("pause");
	return 0;
}

User authUser(char user[], char pass[]) {
	User userObj;
	userObj.valid = false;
	bool found;
	found = false;
	char fname[100];
	char lname[100];
	char uid[100];
	char pwd[100];
	char role[100];
	ifstream file;
	file.open("user.db");
	if (file.is_open()) {
		while (!file.eof()) {
			file >> fname;
			file >> lname;
			file >> uid;
			file >> pwd;
			file >> role;
			if (strcmp(user, uid) == 0 && strcmp(pass, pwd) == 0) {
				strcpy_s(userObj.fname, fname);
				strcpy_s(userObj.lname, lname);
				strcpy_s(userObj.uid, uid);
				strcpy_s(userObj.pwd, pwd);
				strcpy_s(userObj.role, role);
				userObj.valid = true;
				found = true;
			}
		}
	}
	else {
		cout << "Unable to access user database!" << endl;
	}
	file.close();
	return userObj;
}

void listUser() {
	char output[100];
	ifstream file;
	file.open("user.db");
	if (file.is_open()) {
		while (!file.eof()) {
			file >> output;
			cout << output << "\t";
			file >> output;
			cout << output << "\t";
			file >> output;
			cout << output << "\t";
			file >> output;
			cout << output << "\t";
			file >> output;
			cout << output << "\t" << endl;
		}
	}
	else {
		cout << "Unable to access user database!" << endl;
	}
	file.close();
}

void addUser(User uobject) {

	ofstream myWriteFile;
	myWriteFile.open("user.db", std::ios_base::app);

	myWriteFile << "\n" << uobject.fname << "\t" << uobject.lname << "\t" << uobject.uid << "\t" << uobject.pwd << "\t" << uobject.role;

	myWriteFile.close();
}