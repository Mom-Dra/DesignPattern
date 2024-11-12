#pragma once
#include "Subject.h"

class ClockTimer : public Subject
{
public:
	explicit ClockTimer() = default;

	virtual int GetHour();
	virtual int GetMinute();
	virtual int GetSecond();

	void Tick();
};

