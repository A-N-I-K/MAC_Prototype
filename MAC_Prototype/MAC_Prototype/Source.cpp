#include <iostream>
#include <fstream>
#include <string>
#include <mysql.h>

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
bool deleteUser(char user[]);
bool modifyUser(char user[], char newRole[]);
void queryCheck(char *query);
void testCon();

MYSQL *conn;
int version = 1;

int main()
{
	testCon();
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
				User userTmp;
				char input[100];
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
			else if (strcmp(choice, "3") == 0 || strcmp(choice, "Three") == 0 || strcmp(choice, "three") == 0) {
				char input[100];
				char role[100];
				cout << "Please provide the UID of the user you would like to modify:" << endl;
				cin >> input;
				cout << "Please provide the updated role for " << input << ":" << endl;
				cin >> role;
				if (modifyUser(input, role)) {
					cout << "The role for the user "<< input << " has been changed to " << role << "." << endl;
				}
				else {
					cout << "The user " << input << " does not exist!" << endl;
				}
			}
			else if (strcmp(choice, "4") == 0 || strcmp(choice, "Four") == 0 || strcmp(choice, "four") == 0) {
				char input[100];
				cout << "Please provide the UID of the user you would like to delete:" << endl;
				cin >> input;
				if (deleteUser(input)) {
					cout << "The user " << input << " has been deleted." << endl;
				}
				else {
					cout << "The user " << input << " does not exist!" << endl;
				}
			}
			else if (strcmp(choice, "5") == 0 || strcmp(choice, "Five") == 0 || strcmp(choice, "five") == 0) {

			}
			else if (strcmp(choice, "6") == 0 || strcmp(choice, "Six") == 0 || strcmp(choice, "six") == 0) {
				cout << "You have been logged out. Have a great day, " << userObj.fname << "!" << endl;
				session = false;
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

bool deleteUser(char user[])
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

	bool found;
	found = false;

	if (file.is_open()) {
		while (!file.eof()) {
			file >> fname;
			file >> lname;
			file >> uid;
			file >> pwd;
			file >> role;
			if (strcmp(user, uid) == 0) {
				continue;
				found = true;
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

	return found;
}

bool modifyUser(char user[], char newRole[])
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

	bool found;
	found = false;

	if (file.is_open()) {
		while (!file.eof()) {
			file >> fname;
			file >> lname;
			file >> uid;
			file >> pwd;
			file >> role;
			if (strcmp(user, uid) == 0) {
				tempFile << fname << "\t" << lname << "\t" << uid << "\t" << pwd << "\t" << newRole << "\n";
				found = true;
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

	return found;
}

void queryCheck(char *query)
{
	/*string q1 = query;

	q1.erase(std::remove(q1.begin(), q1.end(), ' '), q1.end());		//erasing white spaces

	unsigned FROM = q1.find("FROM");
	unsigned WHERE = q1.find("WHERE");

	string from_to_where = q1.substr(FROM + 4, WHERE - FROM - 4);	//extracted list of table

	char * cstr = new char[from_to_where.length() + 1];		
	const char * m = from_to_where.c_str();		//converting the string to char array

	strcpy_s(cstr, strlen(m) + 1, m);

	char * context = NULL;
	char * p = strtok_s(cstr, ",", &context);		
	string table_name;
	while (p != 0)
	{
		table_name = p;	//extracted table name

		//pass the table name to a function which check whether it is accessible by the user

		p = strtok_s(NULL, ",", &context);

	}

	delete[] cstr;*/
}

void testCon() {
	conn = mysql_init(NULL);
	if (!mysql_real_connect(conn, "localhost", "root", "root", "mac", 0, NULL, 0)) {
		fprintf(stderr, "%s\n", mysql_error(conn));
	}
	else {
		version = mysql_get_server_version(conn);
		printf("\nMySQL Version = %d\n", version);
	}
	mysql_close(conn);
}