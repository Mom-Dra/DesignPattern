#include "Subject.h"
#include "Observer.h"

void Subject::Attach(Observer* o)
{
	observers.emplace_back(o);
}

void Subject::Detach(Observer* o)
{
	observers.remove(o);
}

void Subject::Notify()
{
	for (const auto& o : observers)
	{
		o->Update(this);
	}
}
