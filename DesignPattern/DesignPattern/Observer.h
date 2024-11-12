#pragma once

class Subject;

class Observer
{
public:
	virtual ~Observer() = default;
	virtual void Update(Subject* theChangedSubject) abstract;

protected:
	explicit Observer() = default;
};

