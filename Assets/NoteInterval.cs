using System.Collections;
using System.Collections.Generic;

public enum NoteInterval
{
    UNISON = 0,
    MINOR_SECOND = 1,
    MAJOR_SECOND = 2,
    MINOR_THIRD = 3,
    MAJOR_THIRD = 4,
    PERFECT_FOURTH = 5,
    AUGMENTED_FOURTH = 6,
    DIMINISHED_FIFTH = 6,
    PERFECT_FIFTH = 7,
    MINOR_SIXTH = 8,
    MAJOR_SIXTH = 9,
    MINOR_SEVENTH = 10,
    MAJOR_SEVENTH = 11,
    PERFECT_OCTAVE = 12,
    MINOR_NINTH = 13,
    MAJOR_NINTH = 14,
    MINOR_TENTH = 15,
    MAJOR_TENTH = 16,
    PERFECT_ELEVENTH = 17,
    PERFECT_TWELFTH = 19,
    TRITAVE = 19,
    MINOR_THIRTEENTH = 20,
    MAJOR_THIRTEENTH = 21,
    MINOR_FOURTEENTH = 22,
    MAJOR_FOURTEENTH = 23,
    PERFECT_FIFTEENTH = 24,
    DOUBLE_OCTAVE = 24,
}

public static class IntervalDictionary
{
    public static Dictionary<NoteInterval, int> nameToNumber = new Dictionary<NoteInterval, int> {
        {NoteInterval.UNISON            , 0},
        {NoteInterval.MINOR_SECOND      , 1},
        {NoteInterval.MAJOR_SECOND      , 2},
        {NoteInterval.MINOR_THIRD       , 3},
        {NoteInterval.MAJOR_THIRD       , 4},
        {NoteInterval.PERFECT_FOURTH    , 5},
        {NoteInterval.AUGMENTED_FOURTH  , 6},
        {NoteInterval.PERFECT_FIFTH     , 7},
        {NoteInterval.MINOR_SIXTH       , 8},
        {NoteInterval.MAJOR_SIXTH       , 9},
        {NoteInterval.MINOR_SEVENTH     , 10},
        {NoteInterval.MAJOR_SEVENTH     , 11},
        {NoteInterval.PERFECT_OCTAVE    , 12},
        {NoteInterval.MINOR_NINTH       , 13},
        {NoteInterval.MAJOR_NINTH       , 14},
        {NoteInterval.MINOR_TENTH       , 15},
        {NoteInterval.MAJOR_TENTH       , 16},
        {NoteInterval.PERFECT_ELEVENTH  , 17},
        {NoteInterval.TRITAVE           , 19},
        {NoteInterval.MINOR_THIRTEENTH  , 20},
        {NoteInterval.MAJOR_THIRTEENTH  , 21},
        {NoteInterval.MINOR_FOURTEENTH  , 22},
        {NoteInterval.MAJOR_FOURTEENTH  , 23},
        {NoteInterval.DOUBLE_OCTAVE     , 24},
    };

    public static Dictionary<int, NoteInterval> numberToName = new Dictionary<int, NoteInterval> {
        {0,  NoteInterval.UNISON            },
        {1,  NoteInterval.MINOR_SECOND      },
        {2,  NoteInterval.MAJOR_SECOND      },
        {3,  NoteInterval.MINOR_THIRD       },
        {4,  NoteInterval.MAJOR_THIRD       },
        {5,  NoteInterval.PERFECT_FOURTH    },
        {6,  NoteInterval.AUGMENTED_FOURTH  },
        {7,  NoteInterval.PERFECT_FIFTH     },
        {8,  NoteInterval.MINOR_SIXTH       },
        {9,  NoteInterval.MAJOR_SIXTH       },
        {10, NoteInterval.MINOR_SEVENTH     },
        {11, NoteInterval.MAJOR_SEVENTH     },
        {12, NoteInterval.PERFECT_OCTAVE    },
        {13, NoteInterval.MINOR_NINTH	    },
        {14, NoteInterval.MAJOR_NINTH	    },
        {15, NoteInterval.MINOR_TENTH	    },
        {16, NoteInterval.MAJOR_TENTH	    },
        {17, NoteInterval.PERFECT_ELEVENTH	},
        {19, NoteInterval.TRITAVE	        },
        {20, NoteInterval.MINOR_THIRTEENTH	},
        {21, NoteInterval.MAJOR_THIRTEENTH	},
        {22, NoteInterval.MINOR_FOURTEENTH	},
        {23, NoteInterval.MAJOR_FOURTEENTH	},
        {24, NoteInterval.DOUBLE_OCTAVE	    },
    };
}