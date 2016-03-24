using System;

namespace salary
{
    public interface IAppraisalCalculator
    {
        String Id { get;  }
        String Name { get;  }
        string Description { get;  }
        decimal Calculate();
    }
}
