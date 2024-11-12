#pragma once
#include <list>

class Observer;

class Subject
{
public:
	virtual ~Subject() = default;

	virtual void Attach(Observer* o);
	virtual void Detach(Observer* o);
	virtual void Notify();

protected:
	explicit Subject() = default;
	
private:
	std::list<Observer*> observers;
};

