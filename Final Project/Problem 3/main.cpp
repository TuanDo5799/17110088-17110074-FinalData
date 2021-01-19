//DoKimHoangTuan 17110088
//Nguyen Dinh Thi 17110074
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <conio.h>
#include <iostream>
#include <fstream>
#include <cstring>
using namespace std;
struct Wordtype
{
    string tu, loai, nghia;
};

struct Node
{
    Wordtype word;
    Node *next;
};

Node **D = new Node*[26];

int HashFunction(string tu)
{
    if(tu != "")
    {
        char x = tu[0];
        if((x>96)&&(x<123))
        {
            return x-97;
        }
        return -1;
    }
    return -1;
}

void Initialize(Node **D)
{
    for(int i=0 ;i<26;i++)
    {
        D[i] = NULL;
    }
}

void Add(Node *&curword)
{
    int key = HashFunction(curword->word.tu);
    Node *x = new Node;
    if(D[key] == NULL )
    {
        x->word.tu = curword->word.tu;
        x->word.loai = curword->word.loai;
        x->word.nghia = curword->word.nghia;
        D[key] = x;
    }
    else
    {
        x->word.tu = curword->word.tu;
        x->word.loai = curword->word.loai;
        x->word.nghia = curword->word.nghia;
        x->next = D[key];
        D[key] = x;
    }
}

bool compare(string needfind, Node *cur)
{
    string x = needfind;
    string y = cur->word.tu;
    if(x.length() != y.length())
    {
        return false;
    }
    else
    {
        for(int i=0;i<x.length();i++)
        {
            if(x[i]!=y[i])
            {
                return false;
            }
        }
        return true;
    }
}

void search_item(string needfind)
{
    int key = HashFunction(needfind);
    for(Node *cur = D[key];cur != NULL; cur = cur->next)
    {
        if(compare(needfind,cur))
        {
            cout <<"Word : " << cur->word.tu<<endl;
            cout <<"Type : " << cur->word.loai<<endl;
            cout <<"Meaning: "<< cur->word.nghia<<endl;
        }
    }
}

void Substring(string line, Node *&tmp)
{
    int i=0;
    string tach = "";
    while(line[i] != '@')
    {
        tach += line[i];
        i++;
    }
    i++;
    tmp->word.tu = tach;
    tach = "";
    while(line[i] != '@')
    {
        tach += line[i];
        i++;
    }
    i++;
    tmp->word.loai = tach;
    tach = "";
    while(line[i] != '@')
    {
        tach += line[i];
        i++;
    }
    i++;
    tmp->word.nghia = tach;
}

void ImportWord(string line)
{
    for(int i = 97;i<123;i++)
    {
        if(line[0] == char(i))
        {
            Node *newword = new Node();
            Substring(line,newword);
            newword ->next = NULL;
            Add(newword);
            break;
        }
    }
}

void readfile(Node **D)
{
    ifstream fi("dictionary.txt");
    string line;
    if(fi.is_open())
    {
        while(getline(fi,line))
        {
            fflush(stdin);
            ImportWord(line);
        }
        fi.close();
    }
}

main()
{
    string y;
    cout << "Input finding word : ";
    cin >> y;
    Initialize(D);
    readfile(D);
    search_item(y);
	getch();
}
