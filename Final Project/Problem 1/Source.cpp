//DoKimHoangTuan 17110088
//Nguyen Dinh Thi 17110074
#include<stdio.h>
#include<conio.h>
#include<math.h>
#include <time.h>
#include <stdlib.h>
#include <iostream>
using namespace std;
int n;
struct Node {
	int data;
	Node *next; //Contain the address of the next Node it points to
};

struct List {
	Node *head;
	Node *tail;
};

void Init(List &l) { // Initialize a empty List
	l.head = l.tail = NULL;
}

Node *creatNode(int x) { Initialize a Node
	Node *p = new Node;
	if (p == NULL) exit(1);
	p->next = NULL;
	p->data = x;
	return p;
}

bool isEmpty(List l) { // Check whether the list is empty or not
	if (l.head == NULL) return true;
	return false;
}

//AddHead
void addHead(List &l, int x) {
	Node *p = creatNode(x);
	if (isEmpty(l)) l.head = l.tail = p;
	else {
		p->next = l.head; //The pointer next of p points to the addres of Node head
		l.head = p; // Update Node head
	}
}
//AddTail
void addTail(List &l, int x) {
	Node *p = creatNode(x);
	if (isEmpty(l)) addHead(l, x);
	else {
		l.tail->next = p;
		l.tail = p;
	}
}
//Search for a Node in the list
Node *search(List l, int k) {
	Node *p = l.head;
	while (p != NULL) {
		if (p->data == k) return p;
		else p = p->next;
	}
	return NULL;
}

void addMid(List &l, int x, int k) { //Insert a Node has data = x after a Node has data = k 
	Node *p = search(l, k);
	if (p != NULL) {
		Node *q = creatNode(x);
		Node *r = p->next;
		p->next = q;
		q->next = r;
	}
	else cout << "\nCould not find";
}

void addAtK(List &l, int x, int k) 
{ // chen vi tri bat ki;
	if (isEmpty(l) || k <= 1) addHead(l, x);
	else if (k >= n) addTail(l, x);
	else {
		Node *p = creatNode(x);
		Node *q = new Node, *w = new Node;
		Node *r = l.head;
		int dem = 0;
		while (r != NULL) {
			dem++;
			q = r;
			if (dem == k) break;
			else r = r->next;
		}
		w = l.head;
		while (w->next != q) w = w->next;
		w->next = p;
		p->next = r;
	}
}
// Input a List 
void Input(List &l) {
	cout << "\nInput number of element in the List: "; cin >> n;
	for (int i = 1; i <= n; i++) addTail(l, i);
}
// Display the list on the screen
void Output(List l) {
	Node *p = l.head;
	while (p != NULL) {
		cout << " " << p->data;
		p = p->next;
	}
}
//Remove the first Node of the List
void delHead(List &l) { 
	if (!isEmpty(l)) {
		Node *p = l.head;
		l.head = l.head->next; // Update l.head
		delete p; // Remove the first head Node
	}
}

void delTail(List &l) {
	if (!isEmpty(l)) {
		Node *p = l.head;
		Node *q = new Node;
		while (p->next != l.tail) p = p->next; // Find Node before tail
		q = p; // Assign node q to p
		p = p->next; // p will be Removed
		l.tail = q; // Update l.tail
		l.tail->next = NULL; // Update Node next for l.tail
		delete p;
	}
}

void delAtK(List &l, int k)                       //Remove a Node at position k
{
	if (k <= 1) delHead(l);
	else if (k >= n) delTail(l);
	else {
		int dem = 0;
		if (!isEmpty(l)) {
			Node *p = l.head;
			Node *q = new Node;
			while (p != NULL)
			{                    //Find node at position k
				dem++;
				q = p;
				if (dem == k) break; // Break when finded
				else p = p->next; // Else continuou
			}
			Node *r = l.head;
			while (r->next != q) r = r->next; // Find the node at position k-1
			r->next = q->next; // Let node next of k-1 point to node k+1
			delete q;
		}
	}
}
//List *merge(List *l1, List *l2) 
//{
//	if (!l2) 
//		return l1;
//	else if (!l1) 
//		return l2;
//	List *link = new List;
//	
//}

void QuickSort(List &l) {
	List l1, l2;
	Node *tag, *p;
	if (l.head == l.tail) 
		return;
	Init(l1); Init(l2);
	tag = l.head;
	l.head = l.head->next; // Update l.head
	tag->next = NULL;// Isolate tag
	while (l.head != NULL) {
		p = l.head;
		l.head = l.head->next;
		p->next = NULL;
		if (p->data <= tag->data) addHead(l1, p->data);
		else addHead(l2, p->data);
	}
	QuickSort(l1); // Call recursion to sort l1,l2
	QuickSort(l2);
	if (l1.head != NULL) { // l1 is not empty
		l.head = l1.head;  //let head of l2 assign to head of l1
		l1.tail->next = tag;
	} // l1 is empty
	else l.head = tag;
	tag->next = l2.head;
	if (l2.head != NULL) l.tail = l2.tail;
	else l.tail = tag;
}
//void SortList(int &a, int &b)
//{
//	int temp = a;
//	a = b;
//	b = temp;
//}
//void SelectionSort(List &l)
//{
//	for (Node*p = l.head; p != l.tail; p = p->next)
//	{
//		for (Node*q = p->next; q != NULL; q = q->next)
//			if (p->data > q->data)
//			{
//				SortList(p->data, q->data);
//			}
//	}
//}

void menu() {
	List l;
	List l1;
	List l2;
	Init(l);
	Input(l);
	Output(l);
	int k, x, lc;
	do {
		cout << "\n______MENU______"
			<< "\n1 : Add head."
			<< "\n2 : Add tail."
			<< "\n3 : Add a Node after a Node has data equal to k."
			<< "\n4 : Add a Node at position k"
			<< "\n5 : Output List."
			<< "\n6 : Remove head."
			<< "\n7 : Remove tail."
			<< "\n8 : Remove a Node at position k."
			<< "\n9 : Quicksort"
			<< "\n10 : Selection Sort"
			<< "\n11 : Merge Sort"
			<< "\n0 : Exit. \nWhich one do you choose? ";
		cin >> lc;
		switch (lc) {
		case 0: break;
		case 1: cout << "\nInput x: "; cin >> x; addHead(l, x); n++; break;
		case 2: cout << "\nInput x: "; cin >> x; addTail(l, x); n++; break;
		case 3: cout << "\nInput x, k: "; cin >> x >> k; addMid(l, x, k);n++; break;
		case 4: cout << "\nInput x, position k: "; cin >> x >> k; addAtK(l, x, k); n++; break;
		case 5: Output(l); break;
		case 6: delHead(l); n--; break;
		case 7: delTail(l); n--; break;
		case 8: cout << "\nInput position k: "; cin >> k; delAtK(l, k); n--; break;
		case 9: QuickSort(l); break;
		case 10: SelectionSort(l);break;
		}
	} while (lc != 0);
}
int main() 
{
	menu();
	system("pause");
}