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
void deleteUser(char user[]);
void modifyUser(char user[], char newRole[]);

int main()
{
	/*char fname[100];
	char lname[100];
	char uid[100];
	char pwd[100];
	char role[100];*/
	char user[100];
	char pass[100];
	User userObj;
	cout << "Please provide your username :" << endl;
	cin >> user;
	cout << "Please provide your password :" << endl;
	cin >> pass;
	userObj = authUser(user, pass);
	if (userObj.valid) {
		cout << "Welcome, " << userObj.fname << " " << userObj.lname << "!" << endl;
		bool session;
		session = true;
		while (session) {
			char choice[100];
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
			else if (strcmp(choice, "2") == 0 || strcmp(choice, "Two") == 0 || strcmp(choice, "two") == 0) {
				char input[100];
				User userTmp;
				cout << "First Name:" << endl;
				cin >> input;
				strcpy_s(userTmp.fname, input);
				cout << "last Name:" << endl;
				cin >> input;
				strcpy_s(userTmp.lname, input);
				cout << "UID:" << endl;
				cin >> input;
				strcpy_s(userTmp.uid, input);
				cout << "Password" << endl;
				cin >> input;
				strcpy_s(userTmp.pwd, input);
				cout << "Role:" << endl;
				cin >> input;
				strcpy_s(userTmp.role, input);
				userTmp.valid = true;
				addUser(userTmp);
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

void deleteUser(char user[])
{
	ifstream file;
	file.open("user.db");

	ofstream tempFile;
	tempFile.open("temp.db", std::ios_base::app);

	char fname[100];
	char lname[100];
	char uid[100];
	char pwd[100];
	char role[100];

	if (file.is_open()) {
		while (!file.eof()) {
			file >> fname;
			file >> lname;
			file >> uid;
			file >> pwd;
			file >> role;
			if (strcmp(user, uid) == 0) {
				continue;
			}
			else{
				tempFile << fname << "\t" << lname << "\t" << uid << "\t" << pwd << "\t" << role << "\n";
			}
		}

		file.close();
		tempFile.close();

		remove("user.db");
		rename("temp.db", "user.db");

	}
	else {
		cout << "Unable to access user database!" << endl;
	}

}

void modifyUser(char user[], char newRole[])
{
	ifstream file;
	file.open("user.db");

	ofstream tempFile;
	tempFile.open("temp.db", std::ios_base::app);

	char fname[100];
	char lname[100];
	char uid[100];
	char pwd[100];
	char role[100];

	if (file.is_open()) {
		while (!file.eof()) {
			file >> fname;
			file >> lname;
			file >> uid;
			file >> pwd;
			file >> role;
			if (strcmp(user, uid) == 0) {
				tempFile << fname << "\t" << lname << "\t" << uid << "\t" << pwd << "\t" << newRole << "\n";
			}
			else{
				tempFile << fname << "\t" << lname << "\t" << uid << "\t" << pwd << "\t" << role << "\n";
			}
		}

		file.close();
		tempFile.close();

		remove("user.db");
		rename("temp.db", "user.db");

	}
	else {
		cout << "Unable to access user database!" << endl;
	}

}