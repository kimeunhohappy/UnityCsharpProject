    float second;
    float minute;
    float hour;
34  void Update()
    {
        FlowTime() 
    }
44  void FlowTime()
    {
        second += Time.deltatime
        Debug,Log($"현재시간 : {hour} : {minute} : {second}");

        if(second >=60)
        {
            second = 0;
            minute = minute + 1;
        }

         if(minute >=60)
        {
            minute = 0;
            hour = hour + 1;
        }

    }