﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Winterdom.Viasfora.Text {
  class VB : LanguageKeywords {
    public const String ContentType = "Basic";
    static readonly String[] VB_KEYWORDS = {
         "goto", "resume", "throw", "exit", "stop",
         "do", "loop", "for", "next", "for each",
         "with", "choose", "if", "then", "else", "select",
         "case", "switch", "call", "return", "while"
      };
    static readonly String[] VB_VIS_KEYWORDS = {
         "friend", "public", "private", "protected"
      };
    static readonly String[] VB_LINQ_KEYWORDS = {
         "aggregate", "distinct", "equals", "from", "in",
         "group", "join", "let", "order", "by",
         "skip", "take", "where"
      };
    protected override String[] ControlFlowDefaults {
      get { return VB_KEYWORDS; }
    }
    protected override String[] LinqDefaults {
      get { return VB_LINQ_KEYWORDS; }
    }
    protected override String[] VisibilityDefaults {
      get { return VB_VIS_KEYWORDS; }
    }
    protected override String KeyName {
      get { return "VB"; }
    }
  }
}
