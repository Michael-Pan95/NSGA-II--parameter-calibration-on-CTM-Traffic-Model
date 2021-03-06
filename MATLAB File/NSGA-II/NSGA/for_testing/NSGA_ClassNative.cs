/*
* MATLAB Compiler: 6.0 (R2015a)
* Date: Wed May 31 15:40:51 2017
* Arguments: "-B" "macro_default" "-W" "dotnet:NSGA,NSGA_Class,0.0,private" "-T"
* "link:lib" "-d" "D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\NSGA\for_testing" "-v"
* "class{NSGA_Class:D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\cutoff.m,D:\SHU\大四\毕业
* 论文\潘正宇\NSGA改进\NSGA-II\evaluate_objective.m,D:\SHU\大四\毕业论文\潘正宇\NSGA改进\N
* SGA-II\genetic_operator.m,D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\gz_compute.m,D:\S
* HU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\gz_density.m,D:\SHU\大四\毕业论文\潘正宇\NSGA改
* 进\NSGA-II\gz_enter.m,D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\gz_exit.m,D:\SHU\大四
* \毕业论文\潘正宇\NSGA改进\NSGA-II\gz_flow.m,D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II
* \gz_road.m,D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\gz_speed.m,D:\SHU\大四\毕业论文\
* 潘正宇\NSGA改进\NSGA-II\initialize_variables.m,D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA
* -II\non_domination_sort_mod.m,D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\nsga_2.m,D:\S
* HU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\objective_description_function.m,D:\SHU\大四\毕
* 业论文\潘正宇\NSGA改进\NSGA-II\PI.m,D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\replace
* _chromosome.m,D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\standarization1.m,D:\SHU\大四
* \毕业论文\潘正宇\NSGA改进\NSGA-II\topsis.m,D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\
* tournament_selection.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace NSGANative
{

  /// <summary>
  /// The NSGA_Class class provides a CLS compliant, Object (native) interface to the
  /// MATLAB functions contained in the files:
  /// <newpara></newpara>
  /// D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\cutoff.m
  /// <newpara></newpara>
  /// D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\evaluate_objective.m
  /// <newpara></newpara>
  /// D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\genetic_operator.m
  /// <newpara></newpara>
  /// D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\gz_compute.m
  /// <newpara></newpara>
  /// D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\gz_density.m
  /// <newpara></newpara>
  /// D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\gz_enter.m
  /// <newpara></newpara>
  /// D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\gz_exit.m
  /// <newpara></newpara>
  /// D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\gz_flow.m
  /// <newpara></newpara>
  /// D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\gz_road.m
  /// <newpara></newpara>
  /// D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\gz_speed.m
  /// <newpara></newpara>
  /// D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\initialize_variables.m
  /// <newpara></newpara>
  /// D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\non_domination_sort_mod.m
  /// <newpara></newpara>
  /// D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\nsga_2.m
  /// <newpara></newpara>
  /// D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\objective_description_function.m
  /// <newpara></newpara>
  /// D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\PI.m
  /// <newpara></newpara>
  /// D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\replace_chromosome.m
  /// <newpara></newpara>
  /// D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\standarization1.m
  /// <newpara></newpara>
  /// D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\topsis.m
  /// <newpara></newpara>
  /// D:\SHU\大四\毕业论文\潘正宇\NSGA改进\NSGA-II\tournament_selection.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class NSGA_Class : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB runtime instance.
    /// </summary>
    static NSGA_Class()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "NSGA.ctf";

          Stream embeddedCtfStream = null;

          String[] resourceStrings = assembly.GetManifestResourceNames();

          foreach (String name in resourceStrings)
          {
            if (name.Contains(ctfFileName))
            {
              embeddedCtfStream = assembly.GetManifestResourceStream(name);
              break;
            }
          }
          mcr= new MWMCR("",
                         ctfFilePath, embeddedCtfStream, true);
        }
        catch(Exception ex)
        {
          ex_ = new Exception("MWArray assembly failed to be initialized", ex);
        }
      }
      else
      {
        ex_ = new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the NSGA_Class class.
    /// </summary>
    public NSGA_Class()
    {
      if(ex_ != null)
      {
        throw ex_;
      }
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~NSGA_Class()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the cutoff MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object cutoff()
    {
      return mcr.EvaluateFunction("cutoff", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the cutoff MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x1">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object cutoff(Object x1)
    {
      return mcr.EvaluateFunction("cutoff", x1);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the cutoff MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x1">Input argument #1</param>
    /// <param name="x2">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object cutoff(Object x1, Object x2)
    {
      return mcr.EvaluateFunction("cutoff", x1, x2);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the cutoff MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] cutoff(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "cutoff", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the cutoff MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] cutoff(int numArgsOut, Object x1)
    {
      return mcr.EvaluateFunction(numArgsOut, "cutoff", x1);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the cutoff MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x1">Input argument #1</param>
    /// <param name="x2">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] cutoff(int numArgsOut, Object x1, Object x2)
    {
      return mcr.EvaluateFunction(numArgsOut, "cutoff", x1, x2);
    }


    /// <summary>
    /// Provides an interface for the cutoff function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("cutoff", 2, 1, 0)]
    protected void cutoff(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("cutoff", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the evaluate_objective
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object evaluate_objective()
    {
      return mcr.EvaluateFunction("evaluate_objective", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the evaluate_objective
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object evaluate_objective(Object x)
    {
      return mcr.EvaluateFunction("evaluate_objective", x);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the evaluate_objective
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object evaluate_objective(Object x, Object M)
    {
      return mcr.EvaluateFunction("evaluate_objective", x, M);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the evaluate_objective
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object evaluate_objective(Object x, Object M, Object V)
    {
      return mcr.EvaluateFunction("evaluate_objective", x, M, V);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the evaluate_objective
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="density0">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object evaluate_objective(Object x, Object M, Object V, Object density0)
    {
      return mcr.EvaluateFunction("evaluate_objective", x, M, V, density0);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the evaluate_objective
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="density0">Input argument #4</param>
    /// <param name="input_flow">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object evaluate_objective(Object x, Object M, Object V, Object density0, 
                               Object input_flow)
    {
      return mcr.EvaluateFunction("evaluate_objective", x, M, V, density0, input_flow);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the evaluate_objective
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="density0">Input argument #4</param>
    /// <param name="input_flow">Input argument #5</param>
    /// <param name="exit_density1">Input argument #6</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object evaluate_objective(Object x, Object M, Object V, Object density0, 
                               Object input_flow, Object exit_density1)
    {
      return mcr.EvaluateFunction("evaluate_objective", x, M, V, density0, input_flow, exit_density1);
    }


    /// <summary>
    /// Provides a single output, 7-input Objectinterface to the evaluate_objective
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="density0">Input argument #4</param>
    /// <param name="input_flow">Input argument #5</param>
    /// <param name="exit_density1">Input argument #6</param>
    /// <param name="exit_ratio1">Input argument #7</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object evaluate_objective(Object x, Object M, Object V, Object density0, 
                               Object input_flow, Object exit_density1, Object 
                               exit_ratio1)
    {
      return mcr.EvaluateFunction("evaluate_objective", x, M, V, density0, input_flow, exit_density1, exit_ratio1);
    }


    /// <summary>
    /// Provides a single output, 8-input Objectinterface to the evaluate_objective
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="density0">Input argument #4</param>
    /// <param name="input_flow">Input argument #5</param>
    /// <param name="exit_density1">Input argument #6</param>
    /// <param name="exit_ratio1">Input argument #7</param>
    /// <param name="enter_flow1">Input argument #8</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object evaluate_objective(Object x, Object M, Object V, Object density0, 
                               Object input_flow, Object exit_density1, Object 
                               exit_ratio1, Object enter_flow1)
    {
      return mcr.EvaluateFunction("evaluate_objective", x, M, V, density0, input_flow, exit_density1, exit_ratio1, enter_flow1);
    }


    /// <summary>
    /// Provides a single output, 9-input Objectinterface to the evaluate_objective
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="density0">Input argument #4</param>
    /// <param name="input_flow">Input argument #5</param>
    /// <param name="exit_density1">Input argument #6</param>
    /// <param name="exit_ratio1">Input argument #7</param>
    /// <param name="enter_flow1">Input argument #8</param>
    /// <param name="enter_ratio1">Input argument #9</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object evaluate_objective(Object x, Object M, Object V, Object density0, 
                               Object input_flow, Object exit_density1, Object 
                               exit_ratio1, Object enter_flow1, Object enter_ratio1)
    {
      return mcr.EvaluateFunction("evaluate_objective", x, M, V, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1);
    }


    /// <summary>
    /// Provides a single output, 10-input Objectinterface to the evaluate_objective
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="density0">Input argument #4</param>
    /// <param name="input_flow">Input argument #5</param>
    /// <param name="exit_density1">Input argument #6</param>
    /// <param name="exit_ratio1">Input argument #7</param>
    /// <param name="enter_flow1">Input argument #8</param>
    /// <param name="enter_ratio1">Input argument #9</param>
    /// <param name="enter_flow2">Input argument #10</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object evaluate_objective(Object x, Object M, Object V, Object density0, 
                               Object input_flow, Object exit_density1, Object 
                               exit_ratio1, Object enter_flow1, Object enter_ratio1, 
                               Object enter_flow2)
    {
      return mcr.EvaluateFunction("evaluate_objective", x, M, V, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2);
    }


    /// <summary>
    /// Provides a single output, 11-input Objectinterface to the evaluate_objective
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="density0">Input argument #4</param>
    /// <param name="input_flow">Input argument #5</param>
    /// <param name="exit_density1">Input argument #6</param>
    /// <param name="exit_ratio1">Input argument #7</param>
    /// <param name="enter_flow1">Input argument #8</param>
    /// <param name="enter_ratio1">Input argument #9</param>
    /// <param name="enter_flow2">Input argument #10</param>
    /// <param name="enter_ratio2">Input argument #11</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object evaluate_objective(Object x, Object M, Object V, Object density0, 
                               Object input_flow, Object exit_density1, Object 
                               exit_ratio1, Object enter_flow1, Object enter_ratio1, 
                               Object enter_flow2, Object enter_ratio2)
    {
      return mcr.EvaluateFunction("evaluate_objective", x, M, V, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2);
    }


    /// <summary>
    /// Provides a single output, 12-input Objectinterface to the evaluate_objective
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="density0">Input argument #4</param>
    /// <param name="input_flow">Input argument #5</param>
    /// <param name="exit_density1">Input argument #6</param>
    /// <param name="exit_ratio1">Input argument #7</param>
    /// <param name="enter_flow1">Input argument #8</param>
    /// <param name="enter_ratio1">Input argument #9</param>
    /// <param name="enter_flow2">Input argument #10</param>
    /// <param name="enter_ratio2">Input argument #11</param>
    /// <param name="output_density">Input argument #12</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object evaluate_objective(Object x, Object M, Object V, Object density0, 
                               Object input_flow, Object exit_density1, Object 
                               exit_ratio1, Object enter_flow1, Object enter_ratio1, 
                               Object enter_flow2, Object enter_ratio2, Object 
                               output_density)
    {
      return mcr.EvaluateFunction("evaluate_objective", x, M, V, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density);
    }


    /// <summary>
    /// Provides a single output, 13-input Objectinterface to the evaluate_objective
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="density0">Input argument #4</param>
    /// <param name="input_flow">Input argument #5</param>
    /// <param name="exit_density1">Input argument #6</param>
    /// <param name="exit_ratio1">Input argument #7</param>
    /// <param name="enter_flow1">Input argument #8</param>
    /// <param name="enter_ratio1">Input argument #9</param>
    /// <param name="enter_flow2">Input argument #10</param>
    /// <param name="enter_ratio2">Input argument #11</param>
    /// <param name="output_density">Input argument #12</param>
    /// <param name="flow_data">Input argument #13</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object evaluate_objective(Object x, Object M, Object V, Object density0, 
                               Object input_flow, Object exit_density1, Object 
                               exit_ratio1, Object enter_flow1, Object enter_ratio1, 
                               Object enter_flow2, Object enter_ratio2, Object 
                               output_density, Object flow_data)
    {
      return mcr.EvaluateFunction("evaluate_objective", x, M, V, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data);
    }


    /// <summary>
    /// Provides a single output, 14-input Objectinterface to the evaluate_objective
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="density0">Input argument #4</param>
    /// <param name="input_flow">Input argument #5</param>
    /// <param name="exit_density1">Input argument #6</param>
    /// <param name="exit_ratio1">Input argument #7</param>
    /// <param name="enter_flow1">Input argument #8</param>
    /// <param name="enter_ratio1">Input argument #9</param>
    /// <param name="enter_flow2">Input argument #10</param>
    /// <param name="enter_ratio2">Input argument #11</param>
    /// <param name="output_density">Input argument #12</param>
    /// <param name="flow_data">Input argument #13</param>
    /// <param name="speed_data">Input argument #14</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object evaluate_objective(Object x, Object M, Object V, Object density0, 
                               Object input_flow, Object exit_density1, Object 
                               exit_ratio1, Object enter_flow1, Object enter_ratio1, 
                               Object enter_flow2, Object enter_ratio2, Object 
                               output_density, Object flow_data, Object speed_data)
    {
      return mcr.EvaluateFunction("evaluate_objective", x, M, V, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data, speed_data);
    }


    /// <summary>
    /// Provides a single output, 15-input Objectinterface to the evaluate_objective
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="density0">Input argument #4</param>
    /// <param name="input_flow">Input argument #5</param>
    /// <param name="exit_density1">Input argument #6</param>
    /// <param name="exit_ratio1">Input argument #7</param>
    /// <param name="enter_flow1">Input argument #8</param>
    /// <param name="enter_ratio1">Input argument #9</param>
    /// <param name="enter_flow2">Input argument #10</param>
    /// <param name="enter_ratio2">Input argument #11</param>
    /// <param name="output_density">Input argument #12</param>
    /// <param name="flow_data">Input argument #13</param>
    /// <param name="speed_data">Input argument #14</param>
    /// <param name="hours">Input argument #15</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object evaluate_objective(Object x, Object M, Object V, Object density0, 
                               Object input_flow, Object exit_density1, Object 
                               exit_ratio1, Object enter_flow1, Object enter_ratio1, 
                               Object enter_flow2, Object enter_ratio2, Object 
                               output_density, Object flow_data, Object speed_data, 
                               Object hours)
    {
      return mcr.EvaluateFunction("evaluate_objective", x, M, V, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data, speed_data, hours);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the evaluate_objective MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] evaluate_objective(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "evaluate_objective", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the evaluate_objective MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] evaluate_objective(int numArgsOut, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "evaluate_objective", x);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the evaluate_objective MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] evaluate_objective(int numArgsOut, Object x, Object M)
    {
      return mcr.EvaluateFunction(numArgsOut, "evaluate_objective", x, M);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the evaluate_objective MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] evaluate_objective(int numArgsOut, Object x, Object M, Object V)
    {
      return mcr.EvaluateFunction(numArgsOut, "evaluate_objective", x, M, V);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the evaluate_objective MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="density0">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] evaluate_objective(int numArgsOut, Object x, Object M, Object V, 
                                 Object density0)
    {
      return mcr.EvaluateFunction(numArgsOut, "evaluate_objective", x, M, V, density0);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the evaluate_objective MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="density0">Input argument #4</param>
    /// <param name="input_flow">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] evaluate_objective(int numArgsOut, Object x, Object M, Object V, 
                                 Object density0, Object input_flow)
    {
      return mcr.EvaluateFunction(numArgsOut, "evaluate_objective", x, M, V, density0, input_flow);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the evaluate_objective MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="density0">Input argument #4</param>
    /// <param name="input_flow">Input argument #5</param>
    /// <param name="exit_density1">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] evaluate_objective(int numArgsOut, Object x, Object M, Object V, 
                                 Object density0, Object input_flow, Object exit_density1)
    {
      return mcr.EvaluateFunction(numArgsOut, "evaluate_objective", x, M, V, density0, input_flow, exit_density1);
    }


    /// <summary>
    /// Provides the standard 7-input Object interface to the evaluate_objective MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="density0">Input argument #4</param>
    /// <param name="input_flow">Input argument #5</param>
    /// <param name="exit_density1">Input argument #6</param>
    /// <param name="exit_ratio1">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] evaluate_objective(int numArgsOut, Object x, Object M, Object V, 
                                 Object density0, Object input_flow, Object 
                                 exit_density1, Object exit_ratio1)
    {
      return mcr.EvaluateFunction(numArgsOut, "evaluate_objective", x, M, V, density0, input_flow, exit_density1, exit_ratio1);
    }


    /// <summary>
    /// Provides the standard 8-input Object interface to the evaluate_objective MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="density0">Input argument #4</param>
    /// <param name="input_flow">Input argument #5</param>
    /// <param name="exit_density1">Input argument #6</param>
    /// <param name="exit_ratio1">Input argument #7</param>
    /// <param name="enter_flow1">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] evaluate_objective(int numArgsOut, Object x, Object M, Object V, 
                                 Object density0, Object input_flow, Object 
                                 exit_density1, Object exit_ratio1, Object enter_flow1)
    {
      return mcr.EvaluateFunction(numArgsOut, "evaluate_objective", x, M, V, density0, input_flow, exit_density1, exit_ratio1, enter_flow1);
    }


    /// <summary>
    /// Provides the standard 9-input Object interface to the evaluate_objective MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="density0">Input argument #4</param>
    /// <param name="input_flow">Input argument #5</param>
    /// <param name="exit_density1">Input argument #6</param>
    /// <param name="exit_ratio1">Input argument #7</param>
    /// <param name="enter_flow1">Input argument #8</param>
    /// <param name="enter_ratio1">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] evaluate_objective(int numArgsOut, Object x, Object M, Object V, 
                                 Object density0, Object input_flow, Object 
                                 exit_density1, Object exit_ratio1, Object enter_flow1, 
                                 Object enter_ratio1)
    {
      return mcr.EvaluateFunction(numArgsOut, "evaluate_objective", x, M, V, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1);
    }


    /// <summary>
    /// Provides the standard 10-input Object interface to the evaluate_objective MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="density0">Input argument #4</param>
    /// <param name="input_flow">Input argument #5</param>
    /// <param name="exit_density1">Input argument #6</param>
    /// <param name="exit_ratio1">Input argument #7</param>
    /// <param name="enter_flow1">Input argument #8</param>
    /// <param name="enter_ratio1">Input argument #9</param>
    /// <param name="enter_flow2">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] evaluate_objective(int numArgsOut, Object x, Object M, Object V, 
                                 Object density0, Object input_flow, Object 
                                 exit_density1, Object exit_ratio1, Object enter_flow1, 
                                 Object enter_ratio1, Object enter_flow2)
    {
      return mcr.EvaluateFunction(numArgsOut, "evaluate_objective", x, M, V, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2);
    }


    /// <summary>
    /// Provides the standard 11-input Object interface to the evaluate_objective MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="density0">Input argument #4</param>
    /// <param name="input_flow">Input argument #5</param>
    /// <param name="exit_density1">Input argument #6</param>
    /// <param name="exit_ratio1">Input argument #7</param>
    /// <param name="enter_flow1">Input argument #8</param>
    /// <param name="enter_ratio1">Input argument #9</param>
    /// <param name="enter_flow2">Input argument #10</param>
    /// <param name="enter_ratio2">Input argument #11</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] evaluate_objective(int numArgsOut, Object x, Object M, Object V, 
                                 Object density0, Object input_flow, Object 
                                 exit_density1, Object exit_ratio1, Object enter_flow1, 
                                 Object enter_ratio1, Object enter_flow2, Object 
                                 enter_ratio2)
    {
      return mcr.EvaluateFunction(numArgsOut, "evaluate_objective", x, M, V, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2);
    }


    /// <summary>
    /// Provides the standard 12-input Object interface to the evaluate_objective MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="density0">Input argument #4</param>
    /// <param name="input_flow">Input argument #5</param>
    /// <param name="exit_density1">Input argument #6</param>
    /// <param name="exit_ratio1">Input argument #7</param>
    /// <param name="enter_flow1">Input argument #8</param>
    /// <param name="enter_ratio1">Input argument #9</param>
    /// <param name="enter_flow2">Input argument #10</param>
    /// <param name="enter_ratio2">Input argument #11</param>
    /// <param name="output_density">Input argument #12</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] evaluate_objective(int numArgsOut, Object x, Object M, Object V, 
                                 Object density0, Object input_flow, Object 
                                 exit_density1, Object exit_ratio1, Object enter_flow1, 
                                 Object enter_ratio1, Object enter_flow2, Object 
                                 enter_ratio2, Object output_density)
    {
      return mcr.EvaluateFunction(numArgsOut, "evaluate_objective", x, M, V, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density);
    }


    /// <summary>
    /// Provides the standard 13-input Object interface to the evaluate_objective MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="density0">Input argument #4</param>
    /// <param name="input_flow">Input argument #5</param>
    /// <param name="exit_density1">Input argument #6</param>
    /// <param name="exit_ratio1">Input argument #7</param>
    /// <param name="enter_flow1">Input argument #8</param>
    /// <param name="enter_ratio1">Input argument #9</param>
    /// <param name="enter_flow2">Input argument #10</param>
    /// <param name="enter_ratio2">Input argument #11</param>
    /// <param name="output_density">Input argument #12</param>
    /// <param name="flow_data">Input argument #13</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] evaluate_objective(int numArgsOut, Object x, Object M, Object V, 
                                 Object density0, Object input_flow, Object 
                                 exit_density1, Object exit_ratio1, Object enter_flow1, 
                                 Object enter_ratio1, Object enter_flow2, Object 
                                 enter_ratio2, Object output_density, Object flow_data)
    {
      return mcr.EvaluateFunction(numArgsOut, "evaluate_objective", x, M, V, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data);
    }


    /// <summary>
    /// Provides the standard 14-input Object interface to the evaluate_objective MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="density0">Input argument #4</param>
    /// <param name="input_flow">Input argument #5</param>
    /// <param name="exit_density1">Input argument #6</param>
    /// <param name="exit_ratio1">Input argument #7</param>
    /// <param name="enter_flow1">Input argument #8</param>
    /// <param name="enter_ratio1">Input argument #9</param>
    /// <param name="enter_flow2">Input argument #10</param>
    /// <param name="enter_ratio2">Input argument #11</param>
    /// <param name="output_density">Input argument #12</param>
    /// <param name="flow_data">Input argument #13</param>
    /// <param name="speed_data">Input argument #14</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] evaluate_objective(int numArgsOut, Object x, Object M, Object V, 
                                 Object density0, Object input_flow, Object 
                                 exit_density1, Object exit_ratio1, Object enter_flow1, 
                                 Object enter_ratio1, Object enter_flow2, Object 
                                 enter_ratio2, Object output_density, Object flow_data, 
                                 Object speed_data)
    {
      return mcr.EvaluateFunction(numArgsOut, "evaluate_objective", x, M, V, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data, speed_data);
    }


    /// <summary>
    /// Provides the standard 15-input Object interface to the evaluate_objective MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="density0">Input argument #4</param>
    /// <param name="input_flow">Input argument #5</param>
    /// <param name="exit_density1">Input argument #6</param>
    /// <param name="exit_ratio1">Input argument #7</param>
    /// <param name="enter_flow1">Input argument #8</param>
    /// <param name="enter_ratio1">Input argument #9</param>
    /// <param name="enter_flow2">Input argument #10</param>
    /// <param name="enter_ratio2">Input argument #11</param>
    /// <param name="output_density">Input argument #12</param>
    /// <param name="flow_data">Input argument #13</param>
    /// <param name="speed_data">Input argument #14</param>
    /// <param name="hours">Input argument #15</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] evaluate_objective(int numArgsOut, Object x, Object M, Object V, 
                                 Object density0, Object input_flow, Object 
                                 exit_density1, Object exit_ratio1, Object enter_flow1, 
                                 Object enter_ratio1, Object enter_flow2, Object 
                                 enter_ratio2, Object output_density, Object flow_data, 
                                 Object speed_data, Object hours)
    {
      return mcr.EvaluateFunction(numArgsOut, "evaluate_objective", x, M, V, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data, speed_data, hours);
    }


    /// <summary>
    /// Provides an interface for the evaluate_objective function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// function f = evaluate_objective(x, M, V)
    /// Function to evaluate the objective functions for the given input vector
    /// x. x is an array of decision variables and f(1), f(2), etc are the
    /// objective functions. The algorithm always minimizes the objective
    /// function hence if you would like to maximize the function then multiply
    /// the function by negative one. M is the numebr of objective functions and
    /// V is the number of decision variables. 
    /// This functions is basically written by the user who defines his/her own
    /// objective function. Make sure that the M and V matches your initial user
    /// input. Make sure that the 
    /// An example objective function is given below. It has two six decision
    /// variables are two objective functions.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("evaluate_objective", 15, 1, 0)]
    protected void evaluate_objective(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("evaluate_objective", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object genetic_operator()
    {
      return mcr.EvaluateFunction("genetic_operator", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object genetic_operator(Object parent_chromosome)
    {
      return mcr.EvaluateFunction("genetic_operator", parent_chromosome);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object genetic_operator(Object parent_chromosome, Object M)
    {
      return mcr.EvaluateFunction("genetic_operator", parent_chromosome, M);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object genetic_operator(Object parent_chromosome, Object M, Object V)
    {
      return mcr.EvaluateFunction("genetic_operator", parent_chromosome, M, V);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object genetic_operator(Object parent_chromosome, Object M, Object V, Object 
                             mu)
    {
      return mcr.EvaluateFunction("genetic_operator", parent_chromosome, M, V, mu);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object genetic_operator(Object parent_chromosome, Object M, Object V, Object 
                             mu, Object mum)
    {
      return mcr.EvaluateFunction("genetic_operator", parent_chromosome, M, V, mu, mum);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object genetic_operator(Object parent_chromosome, Object M, Object V, Object 
                             mu, Object mum, Object l_limit)
    {
      return mcr.EvaluateFunction("genetic_operator", parent_chromosome, M, V, mu, mum, l_limit);
    }


    /// <summary>
    /// Provides a single output, 7-input Objectinterface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <param name="u_limit">Input argument #7</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object genetic_operator(Object parent_chromosome, Object M, Object V, Object 
                             mu, Object mum, Object l_limit, Object u_limit)
    {
      return mcr.EvaluateFunction("genetic_operator", parent_chromosome, M, V, mu, mum, l_limit, u_limit);
    }


    /// <summary>
    /// Provides a single output, 8-input Objectinterface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <param name="u_limit">Input argument #7</param>
    /// <param name="density0">Input argument #8</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object genetic_operator(Object parent_chromosome, Object M, Object V, Object 
                             mu, Object mum, Object l_limit, Object u_limit, Object 
                             density0)
    {
      return mcr.EvaluateFunction("genetic_operator", parent_chromosome, M, V, mu, mum, l_limit, u_limit, density0);
    }


    /// <summary>
    /// Provides a single output, 9-input Objectinterface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <param name="u_limit">Input argument #7</param>
    /// <param name="density0">Input argument #8</param>
    /// <param name="input_flow">Input argument #9</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object genetic_operator(Object parent_chromosome, Object M, Object V, Object 
                             mu, Object mum, Object l_limit, Object u_limit, Object 
                             density0, Object input_flow)
    {
      return mcr.EvaluateFunction("genetic_operator", parent_chromosome, M, V, mu, mum, l_limit, u_limit, density0, input_flow);
    }


    /// <summary>
    /// Provides a single output, 10-input Objectinterface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <param name="u_limit">Input argument #7</param>
    /// <param name="density0">Input argument #8</param>
    /// <param name="input_flow">Input argument #9</param>
    /// <param name="exit_density1">Input argument #10</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object genetic_operator(Object parent_chromosome, Object M, Object V, Object 
                             mu, Object mum, Object l_limit, Object u_limit, Object 
                             density0, Object input_flow, Object exit_density1)
    {
      return mcr.EvaluateFunction("genetic_operator", parent_chromosome, M, V, mu, mum, l_limit, u_limit, density0, input_flow, exit_density1);
    }


    /// <summary>
    /// Provides a single output, 11-input Objectinterface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <param name="u_limit">Input argument #7</param>
    /// <param name="density0">Input argument #8</param>
    /// <param name="input_flow">Input argument #9</param>
    /// <param name="exit_density1">Input argument #10</param>
    /// <param name="exit_ratio1">Input argument #11</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object genetic_operator(Object parent_chromosome, Object M, Object V, Object 
                             mu, Object mum, Object l_limit, Object u_limit, Object 
                             density0, Object input_flow, Object exit_density1, Object 
                             exit_ratio1)
    {
      return mcr.EvaluateFunction("genetic_operator", parent_chromosome, M, V, mu, mum, l_limit, u_limit, density0, input_flow, exit_density1, exit_ratio1);
    }


    /// <summary>
    /// Provides a single output, 12-input Objectinterface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <param name="u_limit">Input argument #7</param>
    /// <param name="density0">Input argument #8</param>
    /// <param name="input_flow">Input argument #9</param>
    /// <param name="exit_density1">Input argument #10</param>
    /// <param name="exit_ratio1">Input argument #11</param>
    /// <param name="enter_flow1">Input argument #12</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object genetic_operator(Object parent_chromosome, Object M, Object V, Object 
                             mu, Object mum, Object l_limit, Object u_limit, Object 
                             density0, Object input_flow, Object exit_density1, Object 
                             exit_ratio1, Object enter_flow1)
    {
      return mcr.EvaluateFunction("genetic_operator", parent_chromosome, M, V, mu, mum, l_limit, u_limit, density0, input_flow, exit_density1, exit_ratio1, enter_flow1);
    }


    /// <summary>
    /// Provides a single output, 13-input Objectinterface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <param name="u_limit">Input argument #7</param>
    /// <param name="density0">Input argument #8</param>
    /// <param name="input_flow">Input argument #9</param>
    /// <param name="exit_density1">Input argument #10</param>
    /// <param name="exit_ratio1">Input argument #11</param>
    /// <param name="enter_flow1">Input argument #12</param>
    /// <param name="enter_ratio1">Input argument #13</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object genetic_operator(Object parent_chromosome, Object M, Object V, Object 
                             mu, Object mum, Object l_limit, Object u_limit, Object 
                             density0, Object input_flow, Object exit_density1, Object 
                             exit_ratio1, Object enter_flow1, Object enter_ratio1)
    {
      return mcr.EvaluateFunction("genetic_operator", parent_chromosome, M, V, mu, mum, l_limit, u_limit, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1);
    }


    /// <summary>
    /// Provides a single output, 14-input Objectinterface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <param name="u_limit">Input argument #7</param>
    /// <param name="density0">Input argument #8</param>
    /// <param name="input_flow">Input argument #9</param>
    /// <param name="exit_density1">Input argument #10</param>
    /// <param name="exit_ratio1">Input argument #11</param>
    /// <param name="enter_flow1">Input argument #12</param>
    /// <param name="enter_ratio1">Input argument #13</param>
    /// <param name="enter_flow2">Input argument #14</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object genetic_operator(Object parent_chromosome, Object M, Object V, Object 
                             mu, Object mum, Object l_limit, Object u_limit, Object 
                             density0, Object input_flow, Object exit_density1, Object 
                             exit_ratio1, Object enter_flow1, Object enter_ratio1, Object 
                             enter_flow2)
    {
      return mcr.EvaluateFunction("genetic_operator", parent_chromosome, M, V, mu, mum, l_limit, u_limit, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2);
    }


    /// <summary>
    /// Provides a single output, 15-input Objectinterface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <param name="u_limit">Input argument #7</param>
    /// <param name="density0">Input argument #8</param>
    /// <param name="input_flow">Input argument #9</param>
    /// <param name="exit_density1">Input argument #10</param>
    /// <param name="exit_ratio1">Input argument #11</param>
    /// <param name="enter_flow1">Input argument #12</param>
    /// <param name="enter_ratio1">Input argument #13</param>
    /// <param name="enter_flow2">Input argument #14</param>
    /// <param name="enter_ratio2">Input argument #15</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object genetic_operator(Object parent_chromosome, Object M, Object V, Object 
                             mu, Object mum, Object l_limit, Object u_limit, Object 
                             density0, Object input_flow, Object exit_density1, Object 
                             exit_ratio1, Object enter_flow1, Object enter_ratio1, Object 
                             enter_flow2, Object enter_ratio2)
    {
      return mcr.EvaluateFunction("genetic_operator", parent_chromosome, M, V, mu, mum, l_limit, u_limit, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2);
    }


    /// <summary>
    /// Provides a single output, 16-input Objectinterface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <param name="u_limit">Input argument #7</param>
    /// <param name="density0">Input argument #8</param>
    /// <param name="input_flow">Input argument #9</param>
    /// <param name="exit_density1">Input argument #10</param>
    /// <param name="exit_ratio1">Input argument #11</param>
    /// <param name="enter_flow1">Input argument #12</param>
    /// <param name="enter_ratio1">Input argument #13</param>
    /// <param name="enter_flow2">Input argument #14</param>
    /// <param name="enter_ratio2">Input argument #15</param>
    /// <param name="output_density">Input argument #16</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object genetic_operator(Object parent_chromosome, Object M, Object V, Object 
                             mu, Object mum, Object l_limit, Object u_limit, Object 
                             density0, Object input_flow, Object exit_density1, Object 
                             exit_ratio1, Object enter_flow1, Object enter_ratio1, Object 
                             enter_flow2, Object enter_ratio2, Object output_density)
    {
      return mcr.EvaluateFunction("genetic_operator", parent_chromosome, M, V, mu, mum, l_limit, u_limit, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density);
    }


    /// <summary>
    /// Provides a single output, 17-input Objectinterface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <param name="u_limit">Input argument #7</param>
    /// <param name="density0">Input argument #8</param>
    /// <param name="input_flow">Input argument #9</param>
    /// <param name="exit_density1">Input argument #10</param>
    /// <param name="exit_ratio1">Input argument #11</param>
    /// <param name="enter_flow1">Input argument #12</param>
    /// <param name="enter_ratio1">Input argument #13</param>
    /// <param name="enter_flow2">Input argument #14</param>
    /// <param name="enter_ratio2">Input argument #15</param>
    /// <param name="output_density">Input argument #16</param>
    /// <param name="flow_data">Input argument #17</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object genetic_operator(Object parent_chromosome, Object M, Object V, Object 
                             mu, Object mum, Object l_limit, Object u_limit, Object 
                             density0, Object input_flow, Object exit_density1, Object 
                             exit_ratio1, Object enter_flow1, Object enter_ratio1, Object 
                             enter_flow2, Object enter_ratio2, Object output_density, 
                             Object flow_data)
    {
      return mcr.EvaluateFunction("genetic_operator", parent_chromosome, M, V, mu, mum, l_limit, u_limit, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data);
    }


    /// <summary>
    /// Provides a single output, 18-input Objectinterface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <param name="u_limit">Input argument #7</param>
    /// <param name="density0">Input argument #8</param>
    /// <param name="input_flow">Input argument #9</param>
    /// <param name="exit_density1">Input argument #10</param>
    /// <param name="exit_ratio1">Input argument #11</param>
    /// <param name="enter_flow1">Input argument #12</param>
    /// <param name="enter_ratio1">Input argument #13</param>
    /// <param name="enter_flow2">Input argument #14</param>
    /// <param name="enter_ratio2">Input argument #15</param>
    /// <param name="output_density">Input argument #16</param>
    /// <param name="flow_data">Input argument #17</param>
    /// <param name="speed_data">Input argument #18</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object genetic_operator(Object parent_chromosome, Object M, Object V, Object 
                             mu, Object mum, Object l_limit, Object u_limit, Object 
                             density0, Object input_flow, Object exit_density1, Object 
                             exit_ratio1, Object enter_flow1, Object enter_ratio1, Object 
                             enter_flow2, Object enter_ratio2, Object output_density, 
                             Object flow_data, Object speed_data)
    {
      return mcr.EvaluateFunction("genetic_operator", parent_chromosome, M, V, mu, mum, l_limit, u_limit, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data, speed_data);
    }


    /// <summary>
    /// Provides a single output, 19-input Objectinterface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <param name="u_limit">Input argument #7</param>
    /// <param name="density0">Input argument #8</param>
    /// <param name="input_flow">Input argument #9</param>
    /// <param name="exit_density1">Input argument #10</param>
    /// <param name="exit_ratio1">Input argument #11</param>
    /// <param name="enter_flow1">Input argument #12</param>
    /// <param name="enter_ratio1">Input argument #13</param>
    /// <param name="enter_flow2">Input argument #14</param>
    /// <param name="enter_ratio2">Input argument #15</param>
    /// <param name="output_density">Input argument #16</param>
    /// <param name="flow_data">Input argument #17</param>
    /// <param name="speed_data">Input argument #18</param>
    /// <param name="hours">Input argument #19</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object genetic_operator(Object parent_chromosome, Object M, Object V, Object 
                             mu, Object mum, Object l_limit, Object u_limit, Object 
                             density0, Object input_flow, Object exit_density1, Object 
                             exit_ratio1, Object enter_flow1, Object enter_ratio1, Object 
                             enter_flow2, Object enter_ratio2, Object output_density, 
                             Object flow_data, Object speed_data, Object hours)
    {
      return mcr.EvaluateFunction("genetic_operator", parent_chromosome, M, V, mu, mum, l_limit, u_limit, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data, speed_data, hours);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] genetic_operator(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "genetic_operator", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] genetic_operator(int numArgsOut, Object parent_chromosome)
    {
      return mcr.EvaluateFunction(numArgsOut, "genetic_operator", parent_chromosome);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] genetic_operator(int numArgsOut, Object parent_chromosome, Object M)
    {
      return mcr.EvaluateFunction(numArgsOut, "genetic_operator", parent_chromosome, M);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] genetic_operator(int numArgsOut, Object parent_chromosome, Object M, 
                               Object V)
    {
      return mcr.EvaluateFunction(numArgsOut, "genetic_operator", parent_chromosome, M, V);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] genetic_operator(int numArgsOut, Object parent_chromosome, Object M, 
                               Object V, Object mu)
    {
      return mcr.EvaluateFunction(numArgsOut, "genetic_operator", parent_chromosome, M, V, mu);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] genetic_operator(int numArgsOut, Object parent_chromosome, Object M, 
                               Object V, Object mu, Object mum)
    {
      return mcr.EvaluateFunction(numArgsOut, "genetic_operator", parent_chromosome, M, V, mu, mum);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] genetic_operator(int numArgsOut, Object parent_chromosome, Object M, 
                               Object V, Object mu, Object mum, Object l_limit)
    {
      return mcr.EvaluateFunction(numArgsOut, "genetic_operator", parent_chromosome, M, V, mu, mum, l_limit);
    }


    /// <summary>
    /// Provides the standard 7-input Object interface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <param name="u_limit">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] genetic_operator(int numArgsOut, Object parent_chromosome, Object M, 
                               Object V, Object mu, Object mum, Object l_limit, Object 
                               u_limit)
    {
      return mcr.EvaluateFunction(numArgsOut, "genetic_operator", parent_chromosome, M, V, mu, mum, l_limit, u_limit);
    }


    /// <summary>
    /// Provides the standard 8-input Object interface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <param name="u_limit">Input argument #7</param>
    /// <param name="density0">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] genetic_operator(int numArgsOut, Object parent_chromosome, Object M, 
                               Object V, Object mu, Object mum, Object l_limit, Object 
                               u_limit, Object density0)
    {
      return mcr.EvaluateFunction(numArgsOut, "genetic_operator", parent_chromosome, M, V, mu, mum, l_limit, u_limit, density0);
    }


    /// <summary>
    /// Provides the standard 9-input Object interface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <param name="u_limit">Input argument #7</param>
    /// <param name="density0">Input argument #8</param>
    /// <param name="input_flow">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] genetic_operator(int numArgsOut, Object parent_chromosome, Object M, 
                               Object V, Object mu, Object mum, Object l_limit, Object 
                               u_limit, Object density0, Object input_flow)
    {
      return mcr.EvaluateFunction(numArgsOut, "genetic_operator", parent_chromosome, M, V, mu, mum, l_limit, u_limit, density0, input_flow);
    }


    /// <summary>
    /// Provides the standard 10-input Object interface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <param name="u_limit">Input argument #7</param>
    /// <param name="density0">Input argument #8</param>
    /// <param name="input_flow">Input argument #9</param>
    /// <param name="exit_density1">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] genetic_operator(int numArgsOut, Object parent_chromosome, Object M, 
                               Object V, Object mu, Object mum, Object l_limit, Object 
                               u_limit, Object density0, Object input_flow, Object 
                               exit_density1)
    {
      return mcr.EvaluateFunction(numArgsOut, "genetic_operator", parent_chromosome, M, V, mu, mum, l_limit, u_limit, density0, input_flow, exit_density1);
    }


    /// <summary>
    /// Provides the standard 11-input Object interface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <param name="u_limit">Input argument #7</param>
    /// <param name="density0">Input argument #8</param>
    /// <param name="input_flow">Input argument #9</param>
    /// <param name="exit_density1">Input argument #10</param>
    /// <param name="exit_ratio1">Input argument #11</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] genetic_operator(int numArgsOut, Object parent_chromosome, Object M, 
                               Object V, Object mu, Object mum, Object l_limit, Object 
                               u_limit, Object density0, Object input_flow, Object 
                               exit_density1, Object exit_ratio1)
    {
      return mcr.EvaluateFunction(numArgsOut, "genetic_operator", parent_chromosome, M, V, mu, mum, l_limit, u_limit, density0, input_flow, exit_density1, exit_ratio1);
    }


    /// <summary>
    /// Provides the standard 12-input Object interface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <param name="u_limit">Input argument #7</param>
    /// <param name="density0">Input argument #8</param>
    /// <param name="input_flow">Input argument #9</param>
    /// <param name="exit_density1">Input argument #10</param>
    /// <param name="exit_ratio1">Input argument #11</param>
    /// <param name="enter_flow1">Input argument #12</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] genetic_operator(int numArgsOut, Object parent_chromosome, Object M, 
                               Object V, Object mu, Object mum, Object l_limit, Object 
                               u_limit, Object density0, Object input_flow, Object 
                               exit_density1, Object exit_ratio1, Object enter_flow1)
    {
      return mcr.EvaluateFunction(numArgsOut, "genetic_operator", parent_chromosome, M, V, mu, mum, l_limit, u_limit, density0, input_flow, exit_density1, exit_ratio1, enter_flow1);
    }


    /// <summary>
    /// Provides the standard 13-input Object interface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <param name="u_limit">Input argument #7</param>
    /// <param name="density0">Input argument #8</param>
    /// <param name="input_flow">Input argument #9</param>
    /// <param name="exit_density1">Input argument #10</param>
    /// <param name="exit_ratio1">Input argument #11</param>
    /// <param name="enter_flow1">Input argument #12</param>
    /// <param name="enter_ratio1">Input argument #13</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] genetic_operator(int numArgsOut, Object parent_chromosome, Object M, 
                               Object V, Object mu, Object mum, Object l_limit, Object 
                               u_limit, Object density0, Object input_flow, Object 
                               exit_density1, Object exit_ratio1, Object enter_flow1, 
                               Object enter_ratio1)
    {
      return mcr.EvaluateFunction(numArgsOut, "genetic_operator", parent_chromosome, M, V, mu, mum, l_limit, u_limit, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1);
    }


    /// <summary>
    /// Provides the standard 14-input Object interface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <param name="u_limit">Input argument #7</param>
    /// <param name="density0">Input argument #8</param>
    /// <param name="input_flow">Input argument #9</param>
    /// <param name="exit_density1">Input argument #10</param>
    /// <param name="exit_ratio1">Input argument #11</param>
    /// <param name="enter_flow1">Input argument #12</param>
    /// <param name="enter_ratio1">Input argument #13</param>
    /// <param name="enter_flow2">Input argument #14</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] genetic_operator(int numArgsOut, Object parent_chromosome, Object M, 
                               Object V, Object mu, Object mum, Object l_limit, Object 
                               u_limit, Object density0, Object input_flow, Object 
                               exit_density1, Object exit_ratio1, Object enter_flow1, 
                               Object enter_ratio1, Object enter_flow2)
    {
      return mcr.EvaluateFunction(numArgsOut, "genetic_operator", parent_chromosome, M, V, mu, mum, l_limit, u_limit, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2);
    }


    /// <summary>
    /// Provides the standard 15-input Object interface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <param name="u_limit">Input argument #7</param>
    /// <param name="density0">Input argument #8</param>
    /// <param name="input_flow">Input argument #9</param>
    /// <param name="exit_density1">Input argument #10</param>
    /// <param name="exit_ratio1">Input argument #11</param>
    /// <param name="enter_flow1">Input argument #12</param>
    /// <param name="enter_ratio1">Input argument #13</param>
    /// <param name="enter_flow2">Input argument #14</param>
    /// <param name="enter_ratio2">Input argument #15</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] genetic_operator(int numArgsOut, Object parent_chromosome, Object M, 
                               Object V, Object mu, Object mum, Object l_limit, Object 
                               u_limit, Object density0, Object input_flow, Object 
                               exit_density1, Object exit_ratio1, Object enter_flow1, 
                               Object enter_ratio1, Object enter_flow2, Object 
                               enter_ratio2)
    {
      return mcr.EvaluateFunction(numArgsOut, "genetic_operator", parent_chromosome, M, V, mu, mum, l_limit, u_limit, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2);
    }


    /// <summary>
    /// Provides the standard 16-input Object interface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <param name="u_limit">Input argument #7</param>
    /// <param name="density0">Input argument #8</param>
    /// <param name="input_flow">Input argument #9</param>
    /// <param name="exit_density1">Input argument #10</param>
    /// <param name="exit_ratio1">Input argument #11</param>
    /// <param name="enter_flow1">Input argument #12</param>
    /// <param name="enter_ratio1">Input argument #13</param>
    /// <param name="enter_flow2">Input argument #14</param>
    /// <param name="enter_ratio2">Input argument #15</param>
    /// <param name="output_density">Input argument #16</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] genetic_operator(int numArgsOut, Object parent_chromosome, Object M, 
                               Object V, Object mu, Object mum, Object l_limit, Object 
                               u_limit, Object density0, Object input_flow, Object 
                               exit_density1, Object exit_ratio1, Object enter_flow1, 
                               Object enter_ratio1, Object enter_flow2, Object 
                               enter_ratio2, Object output_density)
    {
      return mcr.EvaluateFunction(numArgsOut, "genetic_operator", parent_chromosome, M, V, mu, mum, l_limit, u_limit, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density);
    }


    /// <summary>
    /// Provides the standard 17-input Object interface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <param name="u_limit">Input argument #7</param>
    /// <param name="density0">Input argument #8</param>
    /// <param name="input_flow">Input argument #9</param>
    /// <param name="exit_density1">Input argument #10</param>
    /// <param name="exit_ratio1">Input argument #11</param>
    /// <param name="enter_flow1">Input argument #12</param>
    /// <param name="enter_ratio1">Input argument #13</param>
    /// <param name="enter_flow2">Input argument #14</param>
    /// <param name="enter_ratio2">Input argument #15</param>
    /// <param name="output_density">Input argument #16</param>
    /// <param name="flow_data">Input argument #17</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] genetic_operator(int numArgsOut, Object parent_chromosome, Object M, 
                               Object V, Object mu, Object mum, Object l_limit, Object 
                               u_limit, Object density0, Object input_flow, Object 
                               exit_density1, Object exit_ratio1, Object enter_flow1, 
                               Object enter_ratio1, Object enter_flow2, Object 
                               enter_ratio2, Object output_density, Object flow_data)
    {
      return mcr.EvaluateFunction(numArgsOut, "genetic_operator", parent_chromosome, M, V, mu, mum, l_limit, u_limit, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data);
    }


    /// <summary>
    /// Provides the standard 18-input Object interface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <param name="u_limit">Input argument #7</param>
    /// <param name="density0">Input argument #8</param>
    /// <param name="input_flow">Input argument #9</param>
    /// <param name="exit_density1">Input argument #10</param>
    /// <param name="exit_ratio1">Input argument #11</param>
    /// <param name="enter_flow1">Input argument #12</param>
    /// <param name="enter_ratio1">Input argument #13</param>
    /// <param name="enter_flow2">Input argument #14</param>
    /// <param name="enter_ratio2">Input argument #15</param>
    /// <param name="output_density">Input argument #16</param>
    /// <param name="flow_data">Input argument #17</param>
    /// <param name="speed_data">Input argument #18</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] genetic_operator(int numArgsOut, Object parent_chromosome, Object M, 
                               Object V, Object mu, Object mum, Object l_limit, Object 
                               u_limit, Object density0, Object input_flow, Object 
                               exit_density1, Object exit_ratio1, Object enter_flow1, 
                               Object enter_ratio1, Object enter_flow2, Object 
                               enter_ratio2, Object output_density, Object flow_data, 
                               Object speed_data)
    {
      return mcr.EvaluateFunction(numArgsOut, "genetic_operator", parent_chromosome, M, V, mu, mum, l_limit, u_limit, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data, speed_data);
    }


    /// <summary>
    /// Provides the standard 19-input Object interface to the genetic_operator MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="parent_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="mu">Input argument #4</param>
    /// <param name="mum">Input argument #5</param>
    /// <param name="l_limit">Input argument #6</param>
    /// <param name="u_limit">Input argument #7</param>
    /// <param name="density0">Input argument #8</param>
    /// <param name="input_flow">Input argument #9</param>
    /// <param name="exit_density1">Input argument #10</param>
    /// <param name="exit_ratio1">Input argument #11</param>
    /// <param name="enter_flow1">Input argument #12</param>
    /// <param name="enter_ratio1">Input argument #13</param>
    /// <param name="enter_flow2">Input argument #14</param>
    /// <param name="enter_ratio2">Input argument #15</param>
    /// <param name="output_density">Input argument #16</param>
    /// <param name="flow_data">Input argument #17</param>
    /// <param name="speed_data">Input argument #18</param>
    /// <param name="hours">Input argument #19</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] genetic_operator(int numArgsOut, Object parent_chromosome, Object M, 
                               Object V, Object mu, Object mum, Object l_limit, Object 
                               u_limit, Object density0, Object input_flow, Object 
                               exit_density1, Object exit_ratio1, Object enter_flow1, 
                               Object enter_ratio1, Object enter_flow2, Object 
                               enter_ratio2, Object output_density, Object flow_data, 
                               Object speed_data, Object hours)
    {
      return mcr.EvaluateFunction(numArgsOut, "genetic_operator", parent_chromosome, M, V, mu, mum, l_limit, u_limit, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data, speed_data, hours);
    }


    /// <summary>
    /// Provides an interface for the genetic_operator function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// function f  = genetic_operator(parent_chromosome, M, V, mu, mum, l_limit,
    /// u_limit)
    /// This function is utilized to produce offsprings from parent chromosomes.
    /// The genetic operators corssover and mutation which are carried out with
    /// slight modifications from the original design. For more information read
    /// the document enclosed. 
    /// parent_chromosome - the set of selected chromosomes.
    /// M - number of objective functions
    /// V - number of decision varaiables
    /// mu - distribution index for crossover (read the enlcosed pdf file)
    /// mum - distribution index for mutation (read the enclosed pdf file)
    /// l_limit - a vector of lower limit for the corresponding decsion variables
    /// u_limit - a vector of upper limit for the corresponding decsion variables
    /// The genetic operation is performed only on the decision variables, that
    /// is the first V elements in the chromosome vector. 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("genetic_operator", 19, 1, 0)]
    protected void genetic_operator(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("genetic_operator", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the gz_compute MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_compute()
    {
      return mcr.EvaluateFunction("gz_compute", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the gz_compute MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density0">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_compute(Object density0)
    {
      return mcr.EvaluateFunction("gz_compute", density0);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the gz_compute MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_compute(Object density0, Object input0)
    {
      return mcr.EvaluateFunction("gz_compute", density0, input0);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the gz_compute MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_compute(Object density0, Object input0, Object exitdensity1)
    {
      return mcr.EvaluateFunction("gz_compute", density0, input0, exitdensity1);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the gz_compute MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <param name="exitratio1">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_compute(Object density0, Object input0, Object exitdensity1, Object 
                       exitratio1)
    {
      return mcr.EvaluateFunction("gz_compute", density0, input0, exitdensity1, exitratio1);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the gz_compute MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <param name="exitratio1">Input argument #4</param>
    /// <param name="enterflow1">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_compute(Object density0, Object input0, Object exitdensity1, Object 
                       exitratio1, Object enterflow1)
    {
      return mcr.EvaluateFunction("gz_compute", density0, input0, exitdensity1, exitratio1, enterflow1);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the gz_compute MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <param name="exitratio1">Input argument #4</param>
    /// <param name="enterflow1">Input argument #5</param>
    /// <param name="enterratio1">Input argument #6</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_compute(Object density0, Object input0, Object exitdensity1, Object 
                       exitratio1, Object enterflow1, Object enterratio1)
    {
      return mcr.EvaluateFunction("gz_compute", density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1);
    }


    /// <summary>
    /// Provides a single output, 7-input Objectinterface to the gz_compute MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <param name="exitratio1">Input argument #4</param>
    /// <param name="enterflow1">Input argument #5</param>
    /// <param name="enterratio1">Input argument #6</param>
    /// <param name="enterflow2">Input argument #7</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_compute(Object density0, Object input0, Object exitdensity1, Object 
                       exitratio1, Object enterflow1, Object enterratio1, Object 
                       enterflow2)
    {
      return mcr.EvaluateFunction("gz_compute", density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2);
    }


    /// <summary>
    /// Provides a single output, 8-input Objectinterface to the gz_compute MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <param name="exitratio1">Input argument #4</param>
    /// <param name="enterflow1">Input argument #5</param>
    /// <param name="enterratio1">Input argument #6</param>
    /// <param name="enterflow2">Input argument #7</param>
    /// <param name="enterratio2">Input argument #8</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_compute(Object density0, Object input0, Object exitdensity1, Object 
                       exitratio1, Object enterflow1, Object enterratio1, Object 
                       enterflow2, Object enterratio2)
    {
      return mcr.EvaluateFunction("gz_compute", density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2);
    }


    /// <summary>
    /// Provides a single output, 9-input Objectinterface to the gz_compute MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <param name="exitratio1">Input argument #4</param>
    /// <param name="enterflow1">Input argument #5</param>
    /// <param name="enterratio1">Input argument #6</param>
    /// <param name="enterflow2">Input argument #7</param>
    /// <param name="enterratio2">Input argument #8</param>
    /// <param name="output">Input argument #9</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_compute(Object density0, Object input0, Object exitdensity1, Object 
                       exitratio1, Object enterflow1, Object enterratio1, Object 
                       enterflow2, Object enterratio2, Object output)
    {
      return mcr.EvaluateFunction("gz_compute", density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output);
    }


    /// <summary>
    /// Provides a single output, 10-input Objectinterface to the gz_compute MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <param name="exitratio1">Input argument #4</param>
    /// <param name="enterflow1">Input argument #5</param>
    /// <param name="enterratio1">Input argument #6</param>
    /// <param name="enterflow2">Input argument #7</param>
    /// <param name="enterratio2">Input argument #8</param>
    /// <param name="output">Input argument #9</param>
    /// <param name="vf">Input argument #10</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_compute(Object density0, Object input0, Object exitdensity1, Object 
                       exitratio1, Object enterflow1, Object enterratio1, Object 
                       enterflow2, Object enterratio2, Object output, Object vf)
    {
      return mcr.EvaluateFunction("gz_compute", density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, vf);
    }


    /// <summary>
    /// Provides a single output, 11-input Objectinterface to the gz_compute MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <param name="exitratio1">Input argument #4</param>
    /// <param name="enterflow1">Input argument #5</param>
    /// <param name="enterratio1">Input argument #6</param>
    /// <param name="enterflow2">Input argument #7</param>
    /// <param name="enterratio2">Input argument #8</param>
    /// <param name="output">Input argument #9</param>
    /// <param name="vf">Input argument #10</param>
    /// <param name="pmax">Input argument #11</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_compute(Object density0, Object input0, Object exitdensity1, Object 
                       exitratio1, Object enterflow1, Object enterratio1, Object 
                       enterflow2, Object enterratio2, Object output, Object vf, Object 
                       pmax)
    {
      return mcr.EvaluateFunction("gz_compute", density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, vf, pmax);
    }


    /// <summary>
    /// Provides a single output, 12-input Objectinterface to the gz_compute MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <param name="exitratio1">Input argument #4</param>
    /// <param name="enterflow1">Input argument #5</param>
    /// <param name="enterratio1">Input argument #6</param>
    /// <param name="enterflow2">Input argument #7</param>
    /// <param name="enterratio2">Input argument #8</param>
    /// <param name="output">Input argument #9</param>
    /// <param name="vf">Input argument #10</param>
    /// <param name="pmax">Input argument #11</param>
    /// <param name="w">Input argument #12</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_compute(Object density0, Object input0, Object exitdensity1, Object 
                       exitratio1, Object enterflow1, Object enterratio1, Object 
                       enterflow2, Object enterratio2, Object output, Object vf, Object 
                       pmax, Object w)
    {
      return mcr.EvaluateFunction("gz_compute", density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, vf, pmax, w);
    }


    /// <summary>
    /// Provides a single output, 13-input Objectinterface to the gz_compute MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <param name="exitratio1">Input argument #4</param>
    /// <param name="enterflow1">Input argument #5</param>
    /// <param name="enterratio1">Input argument #6</param>
    /// <param name="enterflow2">Input argument #7</param>
    /// <param name="enterratio2">Input argument #8</param>
    /// <param name="output">Input argument #9</param>
    /// <param name="vf">Input argument #10</param>
    /// <param name="pmax">Input argument #11</param>
    /// <param name="w">Input argument #12</param>
    /// <param name="Qmax">Input argument #13</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_compute(Object density0, Object input0, Object exitdensity1, Object 
                       exitratio1, Object enterflow1, Object enterratio1, Object 
                       enterflow2, Object enterratio2, Object output, Object vf, Object 
                       pmax, Object w, Object Qmax)
    {
      return mcr.EvaluateFunction("gz_compute", density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, vf, pmax, w, Qmax);
    }


    /// <summary>
    /// Provides a single output, 14-input Objectinterface to the gz_compute MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <param name="exitratio1">Input argument #4</param>
    /// <param name="enterflow1">Input argument #5</param>
    /// <param name="enterratio1">Input argument #6</param>
    /// <param name="enterflow2">Input argument #7</param>
    /// <param name="enterratio2">Input argument #8</param>
    /// <param name="output">Input argument #9</param>
    /// <param name="vf">Input argument #10</param>
    /// <param name="pmax">Input argument #11</param>
    /// <param name="w">Input argument #12</param>
    /// <param name="Qmax">Input argument #13</param>
    /// <param name="woff">Input argument #14</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_compute(Object density0, Object input0, Object exitdensity1, Object 
                       exitratio1, Object enterflow1, Object enterratio1, Object 
                       enterflow2, Object enterratio2, Object output, Object vf, Object 
                       pmax, Object w, Object Qmax, Object woff)
    {
      return mcr.EvaluateFunction("gz_compute", density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, vf, pmax, w, Qmax, woff);
    }


    /// <summary>
    /// Provides a single output, 15-input Objectinterface to the gz_compute MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <param name="exitratio1">Input argument #4</param>
    /// <param name="enterflow1">Input argument #5</param>
    /// <param name="enterratio1">Input argument #6</param>
    /// <param name="enterflow2">Input argument #7</param>
    /// <param name="enterratio2">Input argument #8</param>
    /// <param name="output">Input argument #9</param>
    /// <param name="vf">Input argument #10</param>
    /// <param name="pmax">Input argument #11</param>
    /// <param name="w">Input argument #12</param>
    /// <param name="Qmax">Input argument #13</param>
    /// <param name="woff">Input argument #14</param>
    /// <param name="poff">Input argument #15</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_compute(Object density0, Object input0, Object exitdensity1, Object 
                       exitratio1, Object enterflow1, Object enterratio1, Object 
                       enterflow2, Object enterratio2, Object output, Object vf, Object 
                       pmax, Object w, Object Qmax, Object woff, Object poff)
    {
      return mcr.EvaluateFunction("gz_compute", density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, vf, pmax, w, Qmax, woff, poff);
    }


    /// <summary>
    /// Provides a single output, 16-input Objectinterface to the gz_compute MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <param name="exitratio1">Input argument #4</param>
    /// <param name="enterflow1">Input argument #5</param>
    /// <param name="enterratio1">Input argument #6</param>
    /// <param name="enterflow2">Input argument #7</param>
    /// <param name="enterratio2">Input argument #8</param>
    /// <param name="output">Input argument #9</param>
    /// <param name="vf">Input argument #10</param>
    /// <param name="pmax">Input argument #11</param>
    /// <param name="w">Input argument #12</param>
    /// <param name="Qmax">Input argument #13</param>
    /// <param name="woff">Input argument #14</param>
    /// <param name="poff">Input argument #15</param>
    /// <param name="hours">Input argument #16</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_compute(Object density0, Object input0, Object exitdensity1, Object 
                       exitratio1, Object enterflow1, Object enterratio1, Object 
                       enterflow2, Object enterratio2, Object output, Object vf, Object 
                       pmax, Object w, Object Qmax, Object woff, Object poff, Object 
                       hours)
    {
      return mcr.EvaluateFunction("gz_compute", density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, vf, pmax, w, Qmax, woff, poff, hours);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the gz_compute MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_compute(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_compute", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the gz_compute MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density0">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_compute(int numArgsOut, Object density0)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_compute", density0);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the gz_compute MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_compute(int numArgsOut, Object density0, Object input0)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_compute", density0, input0);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the gz_compute MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_compute(int numArgsOut, Object density0, Object input0, Object 
                         exitdensity1)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_compute", density0, input0, exitdensity1);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the gz_compute MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <param name="exitratio1">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_compute(int numArgsOut, Object density0, Object input0, Object 
                         exitdensity1, Object exitratio1)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_compute", density0, input0, exitdensity1, exitratio1);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the gz_compute MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <param name="exitratio1">Input argument #4</param>
    /// <param name="enterflow1">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_compute(int numArgsOut, Object density0, Object input0, Object 
                         exitdensity1, Object exitratio1, Object enterflow1)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_compute", density0, input0, exitdensity1, exitratio1, enterflow1);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the gz_compute MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <param name="exitratio1">Input argument #4</param>
    /// <param name="enterflow1">Input argument #5</param>
    /// <param name="enterratio1">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_compute(int numArgsOut, Object density0, Object input0, Object 
                         exitdensity1, Object exitratio1, Object enterflow1, Object 
                         enterratio1)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_compute", density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1);
    }


    /// <summary>
    /// Provides the standard 7-input Object interface to the gz_compute MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <param name="exitratio1">Input argument #4</param>
    /// <param name="enterflow1">Input argument #5</param>
    /// <param name="enterratio1">Input argument #6</param>
    /// <param name="enterflow2">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_compute(int numArgsOut, Object density0, Object input0, Object 
                         exitdensity1, Object exitratio1, Object enterflow1, Object 
                         enterratio1, Object enterflow2)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_compute", density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2);
    }


    /// <summary>
    /// Provides the standard 8-input Object interface to the gz_compute MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <param name="exitratio1">Input argument #4</param>
    /// <param name="enterflow1">Input argument #5</param>
    /// <param name="enterratio1">Input argument #6</param>
    /// <param name="enterflow2">Input argument #7</param>
    /// <param name="enterratio2">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_compute(int numArgsOut, Object density0, Object input0, Object 
                         exitdensity1, Object exitratio1, Object enterflow1, Object 
                         enterratio1, Object enterflow2, Object enterratio2)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_compute", density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2);
    }


    /// <summary>
    /// Provides the standard 9-input Object interface to the gz_compute MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <param name="exitratio1">Input argument #4</param>
    /// <param name="enterflow1">Input argument #5</param>
    /// <param name="enterratio1">Input argument #6</param>
    /// <param name="enterflow2">Input argument #7</param>
    /// <param name="enterratio2">Input argument #8</param>
    /// <param name="output">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_compute(int numArgsOut, Object density0, Object input0, Object 
                         exitdensity1, Object exitratio1, Object enterflow1, Object 
                         enterratio1, Object enterflow2, Object enterratio2, Object 
                         output)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_compute", density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output);
    }


    /// <summary>
    /// Provides the standard 10-input Object interface to the gz_compute MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <param name="exitratio1">Input argument #4</param>
    /// <param name="enterflow1">Input argument #5</param>
    /// <param name="enterratio1">Input argument #6</param>
    /// <param name="enterflow2">Input argument #7</param>
    /// <param name="enterratio2">Input argument #8</param>
    /// <param name="output">Input argument #9</param>
    /// <param name="vf">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_compute(int numArgsOut, Object density0, Object input0, Object 
                         exitdensity1, Object exitratio1, Object enterflow1, Object 
                         enterratio1, Object enterflow2, Object enterratio2, Object 
                         output, Object vf)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_compute", density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, vf);
    }


    /// <summary>
    /// Provides the standard 11-input Object interface to the gz_compute MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <param name="exitratio1">Input argument #4</param>
    /// <param name="enterflow1">Input argument #5</param>
    /// <param name="enterratio1">Input argument #6</param>
    /// <param name="enterflow2">Input argument #7</param>
    /// <param name="enterratio2">Input argument #8</param>
    /// <param name="output">Input argument #9</param>
    /// <param name="vf">Input argument #10</param>
    /// <param name="pmax">Input argument #11</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_compute(int numArgsOut, Object density0, Object input0, Object 
                         exitdensity1, Object exitratio1, Object enterflow1, Object 
                         enterratio1, Object enterflow2, Object enterratio2, Object 
                         output, Object vf, Object pmax)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_compute", density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, vf, pmax);
    }


    /// <summary>
    /// Provides the standard 12-input Object interface to the gz_compute MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <param name="exitratio1">Input argument #4</param>
    /// <param name="enterflow1">Input argument #5</param>
    /// <param name="enterratio1">Input argument #6</param>
    /// <param name="enterflow2">Input argument #7</param>
    /// <param name="enterratio2">Input argument #8</param>
    /// <param name="output">Input argument #9</param>
    /// <param name="vf">Input argument #10</param>
    /// <param name="pmax">Input argument #11</param>
    /// <param name="w">Input argument #12</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_compute(int numArgsOut, Object density0, Object input0, Object 
                         exitdensity1, Object exitratio1, Object enterflow1, Object 
                         enterratio1, Object enterflow2, Object enterratio2, Object 
                         output, Object vf, Object pmax, Object w)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_compute", density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, vf, pmax, w);
    }


    /// <summary>
    /// Provides the standard 13-input Object interface to the gz_compute MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <param name="exitratio1">Input argument #4</param>
    /// <param name="enterflow1">Input argument #5</param>
    /// <param name="enterratio1">Input argument #6</param>
    /// <param name="enterflow2">Input argument #7</param>
    /// <param name="enterratio2">Input argument #8</param>
    /// <param name="output">Input argument #9</param>
    /// <param name="vf">Input argument #10</param>
    /// <param name="pmax">Input argument #11</param>
    /// <param name="w">Input argument #12</param>
    /// <param name="Qmax">Input argument #13</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_compute(int numArgsOut, Object density0, Object input0, Object 
                         exitdensity1, Object exitratio1, Object enterflow1, Object 
                         enterratio1, Object enterflow2, Object enterratio2, Object 
                         output, Object vf, Object pmax, Object w, Object Qmax)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_compute", density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, vf, pmax, w, Qmax);
    }


    /// <summary>
    /// Provides the standard 14-input Object interface to the gz_compute MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <param name="exitratio1">Input argument #4</param>
    /// <param name="enterflow1">Input argument #5</param>
    /// <param name="enterratio1">Input argument #6</param>
    /// <param name="enterflow2">Input argument #7</param>
    /// <param name="enterratio2">Input argument #8</param>
    /// <param name="output">Input argument #9</param>
    /// <param name="vf">Input argument #10</param>
    /// <param name="pmax">Input argument #11</param>
    /// <param name="w">Input argument #12</param>
    /// <param name="Qmax">Input argument #13</param>
    /// <param name="woff">Input argument #14</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_compute(int numArgsOut, Object density0, Object input0, Object 
                         exitdensity1, Object exitratio1, Object enterflow1, Object 
                         enterratio1, Object enterflow2, Object enterratio2, Object 
                         output, Object vf, Object pmax, Object w, Object Qmax, Object 
                         woff)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_compute", density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, vf, pmax, w, Qmax, woff);
    }


    /// <summary>
    /// Provides the standard 15-input Object interface to the gz_compute MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <param name="exitratio1">Input argument #4</param>
    /// <param name="enterflow1">Input argument #5</param>
    /// <param name="enterratio1">Input argument #6</param>
    /// <param name="enterflow2">Input argument #7</param>
    /// <param name="enterratio2">Input argument #8</param>
    /// <param name="output">Input argument #9</param>
    /// <param name="vf">Input argument #10</param>
    /// <param name="pmax">Input argument #11</param>
    /// <param name="w">Input argument #12</param>
    /// <param name="Qmax">Input argument #13</param>
    /// <param name="woff">Input argument #14</param>
    /// <param name="poff">Input argument #15</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_compute(int numArgsOut, Object density0, Object input0, Object 
                         exitdensity1, Object exitratio1, Object enterflow1, Object 
                         enterratio1, Object enterflow2, Object enterratio2, Object 
                         output, Object vf, Object pmax, Object w, Object Qmax, Object 
                         woff, Object poff)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_compute", density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, vf, pmax, w, Qmax, woff, poff);
    }


    /// <summary>
    /// Provides the standard 16-input Object interface to the gz_compute MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density0">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="exitdensity1">Input argument #3</param>
    /// <param name="exitratio1">Input argument #4</param>
    /// <param name="enterflow1">Input argument #5</param>
    /// <param name="enterratio1">Input argument #6</param>
    /// <param name="enterflow2">Input argument #7</param>
    /// <param name="enterratio2">Input argument #8</param>
    /// <param name="output">Input argument #9</param>
    /// <param name="vf">Input argument #10</param>
    /// <param name="pmax">Input argument #11</param>
    /// <param name="w">Input argument #12</param>
    /// <param name="Qmax">Input argument #13</param>
    /// <param name="woff">Input argument #14</param>
    /// <param name="poff">Input argument #15</param>
    /// <param name="hours">Input argument #16</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_compute(int numArgsOut, Object density0, Object input0, Object 
                         exitdensity1, Object exitratio1, Object enterflow1, Object 
                         enterratio1, Object enterflow2, Object enterratio2, Object 
                         output, Object vf, Object pmax, Object w, Object Qmax, Object 
                         woff, Object poff, Object hours)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_compute", density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, vf, pmax, w, Qmax, woff, poff, hours);
    }


    /// <summary>
    /// Provides an interface for the gz_compute function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("gz_compute", 16, 3, 0)]
    protected void gz_compute(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("gz_compute", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the gz_density MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_density()
    {
      return mcr.EvaluateFunction("gz_density", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the gz_density MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_density(Object density1)
    {
      return mcr.EvaluateFunction("gz_density", density1);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the gz_density MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_density(Object density1, Object input0)
    {
      return mcr.EvaluateFunction("gz_density", density1, input0);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the gz_density MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="flow">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_density(Object density1, Object input0, Object flow)
    {
      return mcr.EvaluateFunction("gz_density", density1, input0, flow);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the gz_density MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="flow">Input argument #3</param>
    /// <param name="flow3">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_density(Object density1, Object input0, Object flow, Object flow3)
    {
      return mcr.EvaluateFunction("gz_density", density1, input0, flow, flow3);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the gz_density MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_density(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_density", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the gz_density MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_density(int numArgsOut, Object density1)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_density", density1);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the gz_density MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_density(int numArgsOut, Object density1, Object input0)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_density", density1, input0);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the gz_density MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="flow">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_density(int numArgsOut, Object density1, Object input0, Object 
                         flow)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_density", density1, input0, flow);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the gz_density MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="input0">Input argument #2</param>
    /// <param name="flow">Input argument #3</param>
    /// <param name="flow3">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_density(int numArgsOut, Object density1, Object input0, Object 
                         flow, Object flow3)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_density", density1, input0, flow, flow3);
    }


    /// <summary>
    /// Provides an interface for the gz_density function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("gz_density", 4, 1, 0)]
    protected void gz_density(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("gz_density", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the gz_enter MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_enter()
    {
      return mcr.EvaluateFunction("gz_enter", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the gz_enter MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_enter(Object density1)
    {
      return mcr.EvaluateFunction("gz_enter", density1);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the gz_enter MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_enter(Object density1, Object density2)
    {
      return mcr.EvaluateFunction("gz_enter", density1, density2);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the gz_enter MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="enterflow">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_enter(Object density1, Object density2, Object enterflow)
    {
      return mcr.EvaluateFunction("gz_enter", density1, density2, enterflow);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the gz_enter MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="enterflow">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_enter(Object density1, Object density2, Object enterflow, Object vf)
    {
      return mcr.EvaluateFunction("gz_enter", density1, density2, enterflow, vf);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the gz_enter MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="enterflow">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_enter(Object density1, Object density2, Object enterflow, Object vf, 
                     Object Qmax)
    {
      return mcr.EvaluateFunction("gz_enter", density1, density2, enterflow, vf, Qmax);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the gz_enter MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="enterflow">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <param name="pmax">Input argument #6</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_enter(Object density1, Object density2, Object enterflow, Object vf, 
                     Object Qmax, Object pmax)
    {
      return mcr.EvaluateFunction("gz_enter", density1, density2, enterflow, vf, Qmax, pmax);
    }


    /// <summary>
    /// Provides a single output, 7-input Objectinterface to the gz_enter MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="enterflow">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <param name="pmax">Input argument #6</param>
    /// <param name="w">Input argument #7</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_enter(Object density1, Object density2, Object enterflow, Object vf, 
                     Object Qmax, Object pmax, Object w)
    {
      return mcr.EvaluateFunction("gz_enter", density1, density2, enterflow, vf, Qmax, pmax, w);
    }


    /// <summary>
    /// Provides a single output, 8-input Objectinterface to the gz_enter MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="enterflow">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <param name="pmax">Input argument #6</param>
    /// <param name="w">Input argument #7</param>
    /// <param name="lane1">Input argument #8</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_enter(Object density1, Object density2, Object enterflow, Object vf, 
                     Object Qmax, Object pmax, Object w, Object lane1)
    {
      return mcr.EvaluateFunction("gz_enter", density1, density2, enterflow, vf, Qmax, pmax, w, lane1);
    }


    /// <summary>
    /// Provides a single output, 9-input Objectinterface to the gz_enter MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="enterflow">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <param name="pmax">Input argument #6</param>
    /// <param name="w">Input argument #7</param>
    /// <param name="lane1">Input argument #8</param>
    /// <param name="lane2">Input argument #9</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_enter(Object density1, Object density2, Object enterflow, Object vf, 
                     Object Qmax, Object pmax, Object w, Object lane1, Object lane2)
    {
      return mcr.EvaluateFunction("gz_enter", density1, density2, enterflow, vf, Qmax, pmax, w, lane1, lane2);
    }


    /// <summary>
    /// Provides a single output, 10-input Objectinterface to the gz_enter MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="enterflow">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <param name="pmax">Input argument #6</param>
    /// <param name="w">Input argument #7</param>
    /// <param name="lane1">Input argument #8</param>
    /// <param name="lane2">Input argument #9</param>
    /// <param name="enterratio">Input argument #10</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_enter(Object density1, Object density2, Object enterflow, Object vf, 
                     Object Qmax, Object pmax, Object w, Object lane1, Object lane2, 
                     Object enterratio)
    {
      return mcr.EvaluateFunction("gz_enter", density1, density2, enterflow, vf, Qmax, pmax, w, lane1, lane2, enterratio);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the gz_enter MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_enter(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_enter", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the gz_enter MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_enter(int numArgsOut, Object density1)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_enter", density1);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the gz_enter MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_enter(int numArgsOut, Object density1, Object density2)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_enter", density1, density2);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the gz_enter MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="enterflow">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_enter(int numArgsOut, Object density1, Object density2, Object 
                       enterflow)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_enter", density1, density2, enterflow);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the gz_enter MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="enterflow">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_enter(int numArgsOut, Object density1, Object density2, Object 
                       enterflow, Object vf)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_enter", density1, density2, enterflow, vf);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the gz_enter MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="enterflow">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_enter(int numArgsOut, Object density1, Object density2, Object 
                       enterflow, Object vf, Object Qmax)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_enter", density1, density2, enterflow, vf, Qmax);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the gz_enter MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="enterflow">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <param name="pmax">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_enter(int numArgsOut, Object density1, Object density2, Object 
                       enterflow, Object vf, Object Qmax, Object pmax)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_enter", density1, density2, enterflow, vf, Qmax, pmax);
    }


    /// <summary>
    /// Provides the standard 7-input Object interface to the gz_enter MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="enterflow">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <param name="pmax">Input argument #6</param>
    /// <param name="w">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_enter(int numArgsOut, Object density1, Object density2, Object 
                       enterflow, Object vf, Object Qmax, Object pmax, Object w)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_enter", density1, density2, enterflow, vf, Qmax, pmax, w);
    }


    /// <summary>
    /// Provides the standard 8-input Object interface to the gz_enter MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="enterflow">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <param name="pmax">Input argument #6</param>
    /// <param name="w">Input argument #7</param>
    /// <param name="lane1">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_enter(int numArgsOut, Object density1, Object density2, Object 
                       enterflow, Object vf, Object Qmax, Object pmax, Object w, Object 
                       lane1)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_enter", density1, density2, enterflow, vf, Qmax, pmax, w, lane1);
    }


    /// <summary>
    /// Provides the standard 9-input Object interface to the gz_enter MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="enterflow">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <param name="pmax">Input argument #6</param>
    /// <param name="w">Input argument #7</param>
    /// <param name="lane1">Input argument #8</param>
    /// <param name="lane2">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_enter(int numArgsOut, Object density1, Object density2, Object 
                       enterflow, Object vf, Object Qmax, Object pmax, Object w, Object 
                       lane1, Object lane2)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_enter", density1, density2, enterflow, vf, Qmax, pmax, w, lane1, lane2);
    }


    /// <summary>
    /// Provides the standard 10-input Object interface to the gz_enter MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="enterflow">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <param name="pmax">Input argument #6</param>
    /// <param name="w">Input argument #7</param>
    /// <param name="lane1">Input argument #8</param>
    /// <param name="lane2">Input argument #9</param>
    /// <param name="enterratio">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_enter(int numArgsOut, Object density1, Object density2, Object 
                       enterflow, Object vf, Object Qmax, Object pmax, Object w, Object 
                       lane1, Object lane2, Object enterratio)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_enter", density1, density2, enterflow, vf, Qmax, pmax, w, lane1, lane2, enterratio);
    }


    /// <summary>
    /// Provides an interface for the gz_enter function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("gz_enter", 10, 2, 0)]
    protected void gz_enter(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("gz_enter", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the gz_exit MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_exit()
    {
      return mcr.EvaluateFunction("gz_exit", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the gz_exit MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_exit(Object density1)
    {
      return mcr.EvaluateFunction("gz_exit", density1);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the gz_exit MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_exit(Object density1, Object density2)
    {
      return mcr.EvaluateFunction("gz_exit", density1, density2);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the gz_exit MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="exitdensity">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_exit(Object density1, Object density2, Object exitdensity)
    {
      return mcr.EvaluateFunction("gz_exit", density1, density2, exitdensity);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the gz_exit MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="exitdensity">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_exit(Object density1, Object density2, Object exitdensity, Object vf)
    {
      return mcr.EvaluateFunction("gz_exit", density1, density2, exitdensity, vf);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the gz_exit MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="exitdensity">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_exit(Object density1, Object density2, Object exitdensity, Object 
                    vf, Object Qmax)
    {
      return mcr.EvaluateFunction("gz_exit", density1, density2, exitdensity, vf, Qmax);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the gz_exit MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="exitdensity">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <param name="pmax">Input argument #6</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_exit(Object density1, Object density2, Object exitdensity, Object 
                    vf, Object Qmax, Object pmax)
    {
      return mcr.EvaluateFunction("gz_exit", density1, density2, exitdensity, vf, Qmax, pmax);
    }


    /// <summary>
    /// Provides a single output, 7-input Objectinterface to the gz_exit MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="exitdensity">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <param name="pmax">Input argument #6</param>
    /// <param name="w">Input argument #7</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_exit(Object density1, Object density2, Object exitdensity, Object 
                    vf, Object Qmax, Object pmax, Object w)
    {
      return mcr.EvaluateFunction("gz_exit", density1, density2, exitdensity, vf, Qmax, pmax, w);
    }


    /// <summary>
    /// Provides a single output, 8-input Objectinterface to the gz_exit MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="exitdensity">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <param name="pmax">Input argument #6</param>
    /// <param name="w">Input argument #7</param>
    /// <param name="woff">Input argument #8</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_exit(Object density1, Object density2, Object exitdensity, Object 
                    vf, Object Qmax, Object pmax, Object w, Object woff)
    {
      return mcr.EvaluateFunction("gz_exit", density1, density2, exitdensity, vf, Qmax, pmax, w, woff);
    }


    /// <summary>
    /// Provides a single output, 9-input Objectinterface to the gz_exit MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="exitdensity">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <param name="pmax">Input argument #6</param>
    /// <param name="w">Input argument #7</param>
    /// <param name="woff">Input argument #8</param>
    /// <param name="poff">Input argument #9</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_exit(Object density1, Object density2, Object exitdensity, Object 
                    vf, Object Qmax, Object pmax, Object w, Object woff, Object poff)
    {
      return mcr.EvaluateFunction("gz_exit", density1, density2, exitdensity, vf, Qmax, pmax, w, woff, poff);
    }


    /// <summary>
    /// Provides a single output, 10-input Objectinterface to the gz_exit MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="exitdensity">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <param name="pmax">Input argument #6</param>
    /// <param name="w">Input argument #7</param>
    /// <param name="woff">Input argument #8</param>
    /// <param name="poff">Input argument #9</param>
    /// <param name="lane1">Input argument #10</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_exit(Object density1, Object density2, Object exitdensity, Object 
                    vf, Object Qmax, Object pmax, Object w, Object woff, Object poff, 
                    Object lane1)
    {
      return mcr.EvaluateFunction("gz_exit", density1, density2, exitdensity, vf, Qmax, pmax, w, woff, poff, lane1);
    }


    /// <summary>
    /// Provides a single output, 11-input Objectinterface to the gz_exit MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="exitdensity">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <param name="pmax">Input argument #6</param>
    /// <param name="w">Input argument #7</param>
    /// <param name="woff">Input argument #8</param>
    /// <param name="poff">Input argument #9</param>
    /// <param name="lane1">Input argument #10</param>
    /// <param name="lane2">Input argument #11</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_exit(Object density1, Object density2, Object exitdensity, Object 
                    vf, Object Qmax, Object pmax, Object w, Object woff, Object poff, 
                    Object lane1, Object lane2)
    {
      return mcr.EvaluateFunction("gz_exit", density1, density2, exitdensity, vf, Qmax, pmax, w, woff, poff, lane1, lane2);
    }


    /// <summary>
    /// Provides a single output, 12-input Objectinterface to the gz_exit MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="exitdensity">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <param name="pmax">Input argument #6</param>
    /// <param name="w">Input argument #7</param>
    /// <param name="woff">Input argument #8</param>
    /// <param name="poff">Input argument #9</param>
    /// <param name="lane1">Input argument #10</param>
    /// <param name="lane2">Input argument #11</param>
    /// <param name="exitratio">Input argument #12</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_exit(Object density1, Object density2, Object exitdensity, Object 
                    vf, Object Qmax, Object pmax, Object w, Object woff, Object poff, 
                    Object lane1, Object lane2, Object exitratio)
    {
      return mcr.EvaluateFunction("gz_exit", density1, density2, exitdensity, vf, Qmax, pmax, w, woff, poff, lane1, lane2, exitratio);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the gz_exit MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_exit(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_exit", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the gz_exit MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_exit(int numArgsOut, Object density1)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_exit", density1);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the gz_exit MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_exit(int numArgsOut, Object density1, Object density2)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_exit", density1, density2);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the gz_exit MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="exitdensity">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_exit(int numArgsOut, Object density1, Object density2, Object 
                      exitdensity)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_exit", density1, density2, exitdensity);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the gz_exit MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="exitdensity">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_exit(int numArgsOut, Object density1, Object density2, Object 
                      exitdensity, Object vf)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_exit", density1, density2, exitdensity, vf);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the gz_exit MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="exitdensity">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_exit(int numArgsOut, Object density1, Object density2, Object 
                      exitdensity, Object vf, Object Qmax)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_exit", density1, density2, exitdensity, vf, Qmax);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the gz_exit MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="exitdensity">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <param name="pmax">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_exit(int numArgsOut, Object density1, Object density2, Object 
                      exitdensity, Object vf, Object Qmax, Object pmax)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_exit", density1, density2, exitdensity, vf, Qmax, pmax);
    }


    /// <summary>
    /// Provides the standard 7-input Object interface to the gz_exit MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="exitdensity">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <param name="pmax">Input argument #6</param>
    /// <param name="w">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_exit(int numArgsOut, Object density1, Object density2, Object 
                      exitdensity, Object vf, Object Qmax, Object pmax, Object w)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_exit", density1, density2, exitdensity, vf, Qmax, pmax, w);
    }


    /// <summary>
    /// Provides the standard 8-input Object interface to the gz_exit MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="exitdensity">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <param name="pmax">Input argument #6</param>
    /// <param name="w">Input argument #7</param>
    /// <param name="woff">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_exit(int numArgsOut, Object density1, Object density2, Object 
                      exitdensity, Object vf, Object Qmax, Object pmax, Object w, Object 
                      woff)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_exit", density1, density2, exitdensity, vf, Qmax, pmax, w, woff);
    }


    /// <summary>
    /// Provides the standard 9-input Object interface to the gz_exit MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="exitdensity">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <param name="pmax">Input argument #6</param>
    /// <param name="w">Input argument #7</param>
    /// <param name="woff">Input argument #8</param>
    /// <param name="poff">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_exit(int numArgsOut, Object density1, Object density2, Object 
                      exitdensity, Object vf, Object Qmax, Object pmax, Object w, Object 
                      woff, Object poff)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_exit", density1, density2, exitdensity, vf, Qmax, pmax, w, woff, poff);
    }


    /// <summary>
    /// Provides the standard 10-input Object interface to the gz_exit MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="exitdensity">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <param name="pmax">Input argument #6</param>
    /// <param name="w">Input argument #7</param>
    /// <param name="woff">Input argument #8</param>
    /// <param name="poff">Input argument #9</param>
    /// <param name="lane1">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_exit(int numArgsOut, Object density1, Object density2, Object 
                      exitdensity, Object vf, Object Qmax, Object pmax, Object w, Object 
                      woff, Object poff, Object lane1)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_exit", density1, density2, exitdensity, vf, Qmax, pmax, w, woff, poff, lane1);
    }


    /// <summary>
    /// Provides the standard 11-input Object interface to the gz_exit MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="exitdensity">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <param name="pmax">Input argument #6</param>
    /// <param name="w">Input argument #7</param>
    /// <param name="woff">Input argument #8</param>
    /// <param name="poff">Input argument #9</param>
    /// <param name="lane1">Input argument #10</param>
    /// <param name="lane2">Input argument #11</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_exit(int numArgsOut, Object density1, Object density2, Object 
                      exitdensity, Object vf, Object Qmax, Object pmax, Object w, Object 
                      woff, Object poff, Object lane1, Object lane2)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_exit", density1, density2, exitdensity, vf, Qmax, pmax, w, woff, poff, lane1, lane2);
    }


    /// <summary>
    /// Provides the standard 12-input Object interface to the gz_exit MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="exitdensity">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <param name="Qmax">Input argument #5</param>
    /// <param name="pmax">Input argument #6</param>
    /// <param name="w">Input argument #7</param>
    /// <param name="woff">Input argument #8</param>
    /// <param name="poff">Input argument #9</param>
    /// <param name="lane1">Input argument #10</param>
    /// <param name="lane2">Input argument #11</param>
    /// <param name="exitratio">Input argument #12</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_exit(int numArgsOut, Object density1, Object density2, Object 
                      exitdensity, Object vf, Object Qmax, Object pmax, Object w, Object 
                      woff, Object poff, Object lane1, Object lane2, Object exitratio)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_exit", density1, density2, exitdensity, vf, Qmax, pmax, w, woff, poff, lane1, lane2, exitratio);
    }


    /// <summary>
    /// Provides an interface for the gz_exit function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("gz_exit", 12, 2, 0)]
    protected void gz_exit(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("gz_exit", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the gz_flow MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_flow()
    {
      return mcr.EvaluateFunction("gz_flow", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the gz_flow MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="density">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_flow(Object density)
    {
      return mcr.EvaluateFunction("gz_flow", density);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the gz_flow MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="density">Input argument #1</param>
    /// <param name="exitdensity1">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_flow(Object density, Object exitdensity1)
    {
      return mcr.EvaluateFunction("gz_flow", density, exitdensity1);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the gz_flow MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="density">Input argument #1</param>
    /// <param name="exitdensity1">Input argument #2</param>
    /// <param name="exitratio1">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_flow(Object density, Object exitdensity1, Object exitratio1)
    {
      return mcr.EvaluateFunction("gz_flow", density, exitdensity1, exitratio1);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the gz_flow MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="density">Input argument #1</param>
    /// <param name="exitdensity1">Input argument #2</param>
    /// <param name="exitratio1">Input argument #3</param>
    /// <param name="enterflow1">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_flow(Object density, Object exitdensity1, Object exitratio1, Object 
                    enterflow1)
    {
      return mcr.EvaluateFunction("gz_flow", density, exitdensity1, exitratio1, enterflow1);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the gz_flow MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="density">Input argument #1</param>
    /// <param name="exitdensity1">Input argument #2</param>
    /// <param name="exitratio1">Input argument #3</param>
    /// <param name="enterflow1">Input argument #4</param>
    /// <param name="enterratio1">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_flow(Object density, Object exitdensity1, Object exitratio1, Object 
                    enterflow1, Object enterratio1)
    {
      return mcr.EvaluateFunction("gz_flow", density, exitdensity1, exitratio1, enterflow1, enterratio1);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the gz_flow MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="density">Input argument #1</param>
    /// <param name="exitdensity1">Input argument #2</param>
    /// <param name="exitratio1">Input argument #3</param>
    /// <param name="enterflow1">Input argument #4</param>
    /// <param name="enterratio1">Input argument #5</param>
    /// <param name="enterflow2">Input argument #6</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_flow(Object density, Object exitdensity1, Object exitratio1, Object 
                    enterflow1, Object enterratio1, Object enterflow2)
    {
      return mcr.EvaluateFunction("gz_flow", density, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2);
    }


    /// <summary>
    /// Provides a single output, 7-input Objectinterface to the gz_flow MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="density">Input argument #1</param>
    /// <param name="exitdensity1">Input argument #2</param>
    /// <param name="exitratio1">Input argument #3</param>
    /// <param name="enterflow1">Input argument #4</param>
    /// <param name="enterratio1">Input argument #5</param>
    /// <param name="enterflow2">Input argument #6</param>
    /// <param name="enterratio2">Input argument #7</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_flow(Object density, Object exitdensity1, Object exitratio1, Object 
                    enterflow1, Object enterratio1, Object enterflow2, Object enterratio2)
    {
      return mcr.EvaluateFunction("gz_flow", density, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2);
    }


    /// <summary>
    /// Provides a single output, 8-input Objectinterface to the gz_flow MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="density">Input argument #1</param>
    /// <param name="exitdensity1">Input argument #2</param>
    /// <param name="exitratio1">Input argument #3</param>
    /// <param name="enterflow1">Input argument #4</param>
    /// <param name="enterratio1">Input argument #5</param>
    /// <param name="enterflow2">Input argument #6</param>
    /// <param name="enterratio2">Input argument #7</param>
    /// <param name="output">Input argument #8</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_flow(Object density, Object exitdensity1, Object exitratio1, Object 
                    enterflow1, Object enterratio1, Object enterflow2, Object 
                    enterratio2, Object output)
    {
      return mcr.EvaluateFunction("gz_flow", density, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output);
    }


    /// <summary>
    /// Provides a single output, 9-input Objectinterface to the gz_flow MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="density">Input argument #1</param>
    /// <param name="exitdensity1">Input argument #2</param>
    /// <param name="exitratio1">Input argument #3</param>
    /// <param name="enterflow1">Input argument #4</param>
    /// <param name="enterratio1">Input argument #5</param>
    /// <param name="enterflow2">Input argument #6</param>
    /// <param name="enterratio2">Input argument #7</param>
    /// <param name="output">Input argument #8</param>
    /// <param name="vf">Input argument #9</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_flow(Object density, Object exitdensity1, Object exitratio1, Object 
                    enterflow1, Object enterratio1, Object enterflow2, Object 
                    enterratio2, Object output, Object vf)
    {
      return mcr.EvaluateFunction("gz_flow", density, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, vf);
    }


    /// <summary>
    /// Provides a single output, 10-input Objectinterface to the gz_flow MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="density">Input argument #1</param>
    /// <param name="exitdensity1">Input argument #2</param>
    /// <param name="exitratio1">Input argument #3</param>
    /// <param name="enterflow1">Input argument #4</param>
    /// <param name="enterratio1">Input argument #5</param>
    /// <param name="enterflow2">Input argument #6</param>
    /// <param name="enterratio2">Input argument #7</param>
    /// <param name="output">Input argument #8</param>
    /// <param name="vf">Input argument #9</param>
    /// <param name="pmax">Input argument #10</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_flow(Object density, Object exitdensity1, Object exitratio1, Object 
                    enterflow1, Object enterratio1, Object enterflow2, Object 
                    enterratio2, Object output, Object vf, Object pmax)
    {
      return mcr.EvaluateFunction("gz_flow", density, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, vf, pmax);
    }


    /// <summary>
    /// Provides a single output, 11-input Objectinterface to the gz_flow MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="density">Input argument #1</param>
    /// <param name="exitdensity1">Input argument #2</param>
    /// <param name="exitratio1">Input argument #3</param>
    /// <param name="enterflow1">Input argument #4</param>
    /// <param name="enterratio1">Input argument #5</param>
    /// <param name="enterflow2">Input argument #6</param>
    /// <param name="enterratio2">Input argument #7</param>
    /// <param name="output">Input argument #8</param>
    /// <param name="vf">Input argument #9</param>
    /// <param name="pmax">Input argument #10</param>
    /// <param name="w">Input argument #11</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_flow(Object density, Object exitdensity1, Object exitratio1, Object 
                    enterflow1, Object enterratio1, Object enterflow2, Object 
                    enterratio2, Object output, Object vf, Object pmax, Object w)
    {
      return mcr.EvaluateFunction("gz_flow", density, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, vf, pmax, w);
    }


    /// <summary>
    /// Provides a single output, 12-input Objectinterface to the gz_flow MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="density">Input argument #1</param>
    /// <param name="exitdensity1">Input argument #2</param>
    /// <param name="exitratio1">Input argument #3</param>
    /// <param name="enterflow1">Input argument #4</param>
    /// <param name="enterratio1">Input argument #5</param>
    /// <param name="enterflow2">Input argument #6</param>
    /// <param name="enterratio2">Input argument #7</param>
    /// <param name="output">Input argument #8</param>
    /// <param name="vf">Input argument #9</param>
    /// <param name="pmax">Input argument #10</param>
    /// <param name="w">Input argument #11</param>
    /// <param name="Qmax">Input argument #12</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_flow(Object density, Object exitdensity1, Object exitratio1, Object 
                    enterflow1, Object enterratio1, Object enterflow2, Object 
                    enterratio2, Object output, Object vf, Object pmax, Object w, Object 
                    Qmax)
    {
      return mcr.EvaluateFunction("gz_flow", density, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, vf, pmax, w, Qmax);
    }


    /// <summary>
    /// Provides a single output, 13-input Objectinterface to the gz_flow MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="density">Input argument #1</param>
    /// <param name="exitdensity1">Input argument #2</param>
    /// <param name="exitratio1">Input argument #3</param>
    /// <param name="enterflow1">Input argument #4</param>
    /// <param name="enterratio1">Input argument #5</param>
    /// <param name="enterflow2">Input argument #6</param>
    /// <param name="enterratio2">Input argument #7</param>
    /// <param name="output">Input argument #8</param>
    /// <param name="vf">Input argument #9</param>
    /// <param name="pmax">Input argument #10</param>
    /// <param name="w">Input argument #11</param>
    /// <param name="Qmax">Input argument #12</param>
    /// <param name="woff">Input argument #13</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_flow(Object density, Object exitdensity1, Object exitratio1, Object 
                    enterflow1, Object enterratio1, Object enterflow2, Object 
                    enterratio2, Object output, Object vf, Object pmax, Object w, Object 
                    Qmax, Object woff)
    {
      return mcr.EvaluateFunction("gz_flow", density, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, vf, pmax, w, Qmax, woff);
    }


    /// <summary>
    /// Provides a single output, 14-input Objectinterface to the gz_flow MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="density">Input argument #1</param>
    /// <param name="exitdensity1">Input argument #2</param>
    /// <param name="exitratio1">Input argument #3</param>
    /// <param name="enterflow1">Input argument #4</param>
    /// <param name="enterratio1">Input argument #5</param>
    /// <param name="enterflow2">Input argument #6</param>
    /// <param name="enterratio2">Input argument #7</param>
    /// <param name="output">Input argument #8</param>
    /// <param name="vf">Input argument #9</param>
    /// <param name="pmax">Input argument #10</param>
    /// <param name="w">Input argument #11</param>
    /// <param name="Qmax">Input argument #12</param>
    /// <param name="woff">Input argument #13</param>
    /// <param name="poff">Input argument #14</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_flow(Object density, Object exitdensity1, Object exitratio1, Object 
                    enterflow1, Object enterratio1, Object enterflow2, Object 
                    enterratio2, Object output, Object vf, Object pmax, Object w, Object 
                    Qmax, Object woff, Object poff)
    {
      return mcr.EvaluateFunction("gz_flow", density, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, vf, pmax, w, Qmax, woff, poff);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the gz_flow MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_flow(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_flow", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the gz_flow MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_flow(int numArgsOut, Object density)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_flow", density);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the gz_flow MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density">Input argument #1</param>
    /// <param name="exitdensity1">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_flow(int numArgsOut, Object density, Object exitdensity1)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_flow", density, exitdensity1);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the gz_flow MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density">Input argument #1</param>
    /// <param name="exitdensity1">Input argument #2</param>
    /// <param name="exitratio1">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_flow(int numArgsOut, Object density, Object exitdensity1, Object 
                      exitratio1)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_flow", density, exitdensity1, exitratio1);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the gz_flow MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density">Input argument #1</param>
    /// <param name="exitdensity1">Input argument #2</param>
    /// <param name="exitratio1">Input argument #3</param>
    /// <param name="enterflow1">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_flow(int numArgsOut, Object density, Object exitdensity1, Object 
                      exitratio1, Object enterflow1)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_flow", density, exitdensity1, exitratio1, enterflow1);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the gz_flow MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density">Input argument #1</param>
    /// <param name="exitdensity1">Input argument #2</param>
    /// <param name="exitratio1">Input argument #3</param>
    /// <param name="enterflow1">Input argument #4</param>
    /// <param name="enterratio1">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_flow(int numArgsOut, Object density, Object exitdensity1, Object 
                      exitratio1, Object enterflow1, Object enterratio1)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_flow", density, exitdensity1, exitratio1, enterflow1, enterratio1);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the gz_flow MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density">Input argument #1</param>
    /// <param name="exitdensity1">Input argument #2</param>
    /// <param name="exitratio1">Input argument #3</param>
    /// <param name="enterflow1">Input argument #4</param>
    /// <param name="enterratio1">Input argument #5</param>
    /// <param name="enterflow2">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_flow(int numArgsOut, Object density, Object exitdensity1, Object 
                      exitratio1, Object enterflow1, Object enterratio1, Object 
                      enterflow2)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_flow", density, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2);
    }


    /// <summary>
    /// Provides the standard 7-input Object interface to the gz_flow MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density">Input argument #1</param>
    /// <param name="exitdensity1">Input argument #2</param>
    /// <param name="exitratio1">Input argument #3</param>
    /// <param name="enterflow1">Input argument #4</param>
    /// <param name="enterratio1">Input argument #5</param>
    /// <param name="enterflow2">Input argument #6</param>
    /// <param name="enterratio2">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_flow(int numArgsOut, Object density, Object exitdensity1, Object 
                      exitratio1, Object enterflow1, Object enterratio1, Object 
                      enterflow2, Object enterratio2)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_flow", density, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2);
    }


    /// <summary>
    /// Provides the standard 8-input Object interface to the gz_flow MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density">Input argument #1</param>
    /// <param name="exitdensity1">Input argument #2</param>
    /// <param name="exitratio1">Input argument #3</param>
    /// <param name="enterflow1">Input argument #4</param>
    /// <param name="enterratio1">Input argument #5</param>
    /// <param name="enterflow2">Input argument #6</param>
    /// <param name="enterratio2">Input argument #7</param>
    /// <param name="output">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_flow(int numArgsOut, Object density, Object exitdensity1, Object 
                      exitratio1, Object enterflow1, Object enterratio1, Object 
                      enterflow2, Object enterratio2, Object output)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_flow", density, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output);
    }


    /// <summary>
    /// Provides the standard 9-input Object interface to the gz_flow MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density">Input argument #1</param>
    /// <param name="exitdensity1">Input argument #2</param>
    /// <param name="exitratio1">Input argument #3</param>
    /// <param name="enterflow1">Input argument #4</param>
    /// <param name="enterratio1">Input argument #5</param>
    /// <param name="enterflow2">Input argument #6</param>
    /// <param name="enterratio2">Input argument #7</param>
    /// <param name="output">Input argument #8</param>
    /// <param name="vf">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_flow(int numArgsOut, Object density, Object exitdensity1, Object 
                      exitratio1, Object enterflow1, Object enterratio1, Object 
                      enterflow2, Object enterratio2, Object output, Object vf)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_flow", density, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, vf);
    }


    /// <summary>
    /// Provides the standard 10-input Object interface to the gz_flow MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density">Input argument #1</param>
    /// <param name="exitdensity1">Input argument #2</param>
    /// <param name="exitratio1">Input argument #3</param>
    /// <param name="enterflow1">Input argument #4</param>
    /// <param name="enterratio1">Input argument #5</param>
    /// <param name="enterflow2">Input argument #6</param>
    /// <param name="enterratio2">Input argument #7</param>
    /// <param name="output">Input argument #8</param>
    /// <param name="vf">Input argument #9</param>
    /// <param name="pmax">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_flow(int numArgsOut, Object density, Object exitdensity1, Object 
                      exitratio1, Object enterflow1, Object enterratio1, Object 
                      enterflow2, Object enterratio2, Object output, Object vf, Object 
                      pmax)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_flow", density, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, vf, pmax);
    }


    /// <summary>
    /// Provides the standard 11-input Object interface to the gz_flow MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density">Input argument #1</param>
    /// <param name="exitdensity1">Input argument #2</param>
    /// <param name="exitratio1">Input argument #3</param>
    /// <param name="enterflow1">Input argument #4</param>
    /// <param name="enterratio1">Input argument #5</param>
    /// <param name="enterflow2">Input argument #6</param>
    /// <param name="enterratio2">Input argument #7</param>
    /// <param name="output">Input argument #8</param>
    /// <param name="vf">Input argument #9</param>
    /// <param name="pmax">Input argument #10</param>
    /// <param name="w">Input argument #11</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_flow(int numArgsOut, Object density, Object exitdensity1, Object 
                      exitratio1, Object enterflow1, Object enterratio1, Object 
                      enterflow2, Object enterratio2, Object output, Object vf, Object 
                      pmax, Object w)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_flow", density, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, vf, pmax, w);
    }


    /// <summary>
    /// Provides the standard 12-input Object interface to the gz_flow MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density">Input argument #1</param>
    /// <param name="exitdensity1">Input argument #2</param>
    /// <param name="exitratio1">Input argument #3</param>
    /// <param name="enterflow1">Input argument #4</param>
    /// <param name="enterratio1">Input argument #5</param>
    /// <param name="enterflow2">Input argument #6</param>
    /// <param name="enterratio2">Input argument #7</param>
    /// <param name="output">Input argument #8</param>
    /// <param name="vf">Input argument #9</param>
    /// <param name="pmax">Input argument #10</param>
    /// <param name="w">Input argument #11</param>
    /// <param name="Qmax">Input argument #12</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_flow(int numArgsOut, Object density, Object exitdensity1, Object 
                      exitratio1, Object enterflow1, Object enterratio1, Object 
                      enterflow2, Object enterratio2, Object output, Object vf, Object 
                      pmax, Object w, Object Qmax)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_flow", density, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, vf, pmax, w, Qmax);
    }


    /// <summary>
    /// Provides the standard 13-input Object interface to the gz_flow MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density">Input argument #1</param>
    /// <param name="exitdensity1">Input argument #2</param>
    /// <param name="exitratio1">Input argument #3</param>
    /// <param name="enterflow1">Input argument #4</param>
    /// <param name="enterratio1">Input argument #5</param>
    /// <param name="enterflow2">Input argument #6</param>
    /// <param name="enterratio2">Input argument #7</param>
    /// <param name="output">Input argument #8</param>
    /// <param name="vf">Input argument #9</param>
    /// <param name="pmax">Input argument #10</param>
    /// <param name="w">Input argument #11</param>
    /// <param name="Qmax">Input argument #12</param>
    /// <param name="woff">Input argument #13</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_flow(int numArgsOut, Object density, Object exitdensity1, Object 
                      exitratio1, Object enterflow1, Object enterratio1, Object 
                      enterflow2, Object enterratio2, Object output, Object vf, Object 
                      pmax, Object w, Object Qmax, Object woff)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_flow", density, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, vf, pmax, w, Qmax, woff);
    }


    /// <summary>
    /// Provides the standard 14-input Object interface to the gz_flow MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density">Input argument #1</param>
    /// <param name="exitdensity1">Input argument #2</param>
    /// <param name="exitratio1">Input argument #3</param>
    /// <param name="enterflow1">Input argument #4</param>
    /// <param name="enterratio1">Input argument #5</param>
    /// <param name="enterflow2">Input argument #6</param>
    /// <param name="enterratio2">Input argument #7</param>
    /// <param name="output">Input argument #8</param>
    /// <param name="vf">Input argument #9</param>
    /// <param name="pmax">Input argument #10</param>
    /// <param name="w">Input argument #11</param>
    /// <param name="Qmax">Input argument #12</param>
    /// <param name="woff">Input argument #13</param>
    /// <param name="poff">Input argument #14</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_flow(int numArgsOut, Object density, Object exitdensity1, Object 
                      exitratio1, Object enterflow1, Object enterratio1, Object 
                      enterflow2, Object enterratio2, Object output, Object vf, Object 
                      pmax, Object w, Object Qmax, Object woff, Object poff)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_flow", density, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, vf, pmax, w, Qmax, woff, poff);
    }


    /// <summary>
    /// Provides an interface for the gz_flow function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// --第一个元胞--  
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("gz_flow", 14, 3, 0)]
    protected void gz_flow(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("gz_flow", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the gz_road MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_road()
    {
      return mcr.EvaluateFunction("gz_road", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the gz_road MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_road(Object density1)
    {
      return mcr.EvaluateFunction("gz_road", density1);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the gz_road MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_road(Object density1, Object density2)
    {
      return mcr.EvaluateFunction("gz_road", density1, density2);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the gz_road MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="vf">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_road(Object density1, Object density2, Object vf)
    {
      return mcr.EvaluateFunction("gz_road", density1, density2, vf);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the gz_road MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="vf">Input argument #3</param>
    /// <param name="Qmax">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_road(Object density1, Object density2, Object vf, Object Qmax)
    {
      return mcr.EvaluateFunction("gz_road", density1, density2, vf, Qmax);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the gz_road MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="vf">Input argument #3</param>
    /// <param name="Qmax">Input argument #4</param>
    /// <param name="pmax">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_road(Object density1, Object density2, Object vf, Object Qmax, 
                    Object pmax)
    {
      return mcr.EvaluateFunction("gz_road", density1, density2, vf, Qmax, pmax);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the gz_road MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="vf">Input argument #3</param>
    /// <param name="Qmax">Input argument #4</param>
    /// <param name="pmax">Input argument #5</param>
    /// <param name="w">Input argument #6</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_road(Object density1, Object density2, Object vf, Object Qmax, 
                    Object pmax, Object w)
    {
      return mcr.EvaluateFunction("gz_road", density1, density2, vf, Qmax, pmax, w);
    }


    /// <summary>
    /// Provides a single output, 7-input Objectinterface to the gz_road MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="vf">Input argument #3</param>
    /// <param name="Qmax">Input argument #4</param>
    /// <param name="pmax">Input argument #5</param>
    /// <param name="w">Input argument #6</param>
    /// <param name="lane1">Input argument #7</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_road(Object density1, Object density2, Object vf, Object Qmax, 
                    Object pmax, Object w, Object lane1)
    {
      return mcr.EvaluateFunction("gz_road", density1, density2, vf, Qmax, pmax, w, lane1);
    }


    /// <summary>
    /// Provides a single output, 8-input Objectinterface to the gz_road MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="vf">Input argument #3</param>
    /// <param name="Qmax">Input argument #4</param>
    /// <param name="pmax">Input argument #5</param>
    /// <param name="w">Input argument #6</param>
    /// <param name="lane1">Input argument #7</param>
    /// <param name="lane2">Input argument #8</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_road(Object density1, Object density2, Object vf, Object Qmax, 
                    Object pmax, Object w, Object lane1, Object lane2)
    {
      return mcr.EvaluateFunction("gz_road", density1, density2, vf, Qmax, pmax, w, lane1, lane2);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the gz_road MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_road(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_road", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the gz_road MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_road(int numArgsOut, Object density1)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_road", density1);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the gz_road MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_road(int numArgsOut, Object density1, Object density2)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_road", density1, density2);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the gz_road MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="vf">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_road(int numArgsOut, Object density1, Object density2, Object vf)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_road", density1, density2, vf);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the gz_road MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="vf">Input argument #3</param>
    /// <param name="Qmax">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_road(int numArgsOut, Object density1, Object density2, Object vf, 
                      Object Qmax)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_road", density1, density2, vf, Qmax);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the gz_road MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="vf">Input argument #3</param>
    /// <param name="Qmax">Input argument #4</param>
    /// <param name="pmax">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_road(int numArgsOut, Object density1, Object density2, Object vf, 
                      Object Qmax, Object pmax)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_road", density1, density2, vf, Qmax, pmax);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the gz_road MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="vf">Input argument #3</param>
    /// <param name="Qmax">Input argument #4</param>
    /// <param name="pmax">Input argument #5</param>
    /// <param name="w">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_road(int numArgsOut, Object density1, Object density2, Object vf, 
                      Object Qmax, Object pmax, Object w)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_road", density1, density2, vf, Qmax, pmax, w);
    }


    /// <summary>
    /// Provides the standard 7-input Object interface to the gz_road MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="vf">Input argument #3</param>
    /// <param name="Qmax">Input argument #4</param>
    /// <param name="pmax">Input argument #5</param>
    /// <param name="w">Input argument #6</param>
    /// <param name="lane1">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_road(int numArgsOut, Object density1, Object density2, Object vf, 
                      Object Qmax, Object pmax, Object w, Object lane1)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_road", density1, density2, vf, Qmax, pmax, w, lane1);
    }


    /// <summary>
    /// Provides the standard 8-input Object interface to the gz_road MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="density1">Input argument #1</param>
    /// <param name="density2">Input argument #2</param>
    /// <param name="vf">Input argument #3</param>
    /// <param name="Qmax">Input argument #4</param>
    /// <param name="pmax">Input argument #5</param>
    /// <param name="w">Input argument #6</param>
    /// <param name="lane1">Input argument #7</param>
    /// <param name="lane2">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_road(int numArgsOut, Object density1, Object density2, Object vf, 
                      Object Qmax, Object pmax, Object w, Object lane1, Object lane2)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_road", density1, density2, vf, Qmax, pmax, w, lane1, lane2);
    }


    /// <summary>
    /// Provides an interface for the gz_road function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("gz_road", 8, 1, 0)]
    protected void gz_road(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("gz_road", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the gz_speed MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_speed()
    {
      return mcr.EvaluateFunction("gz_speed", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the gz_speed MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="flow">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_speed(Object flow)
    {
      return mcr.EvaluateFunction("gz_speed", flow);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the gz_speed MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="flow">Input argument #1</param>
    /// <param name="density">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_speed(Object flow, Object density)
    {
      return mcr.EvaluateFunction("gz_speed", flow, density);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the gz_speed MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="flow">Input argument #1</param>
    /// <param name="density">Input argument #2</param>
    /// <param name="lane">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_speed(Object flow, Object density, Object lane)
    {
      return mcr.EvaluateFunction("gz_speed", flow, density, lane);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the gz_speed MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="flow">Input argument #1</param>
    /// <param name="density">Input argument #2</param>
    /// <param name="lane">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object gz_speed(Object flow, Object density, Object lane, Object vf)
    {
      return mcr.EvaluateFunction("gz_speed", flow, density, lane, vf);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the gz_speed MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_speed(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_speed", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the gz_speed MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="flow">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_speed(int numArgsOut, Object flow)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_speed", flow);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the gz_speed MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="flow">Input argument #1</param>
    /// <param name="density">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_speed(int numArgsOut, Object flow, Object density)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_speed", flow, density);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the gz_speed MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="flow">Input argument #1</param>
    /// <param name="density">Input argument #2</param>
    /// <param name="lane">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_speed(int numArgsOut, Object flow, Object density, Object lane)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_speed", flow, density, lane);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the gz_speed MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="flow">Input argument #1</param>
    /// <param name="density">Input argument #2</param>
    /// <param name="lane">Input argument #3</param>
    /// <param name="vf">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] gz_speed(int numArgsOut, Object flow, Object density, Object lane, 
                       Object vf)
    {
      return mcr.EvaluateFunction(numArgsOut, "gz_speed", flow, density, lane, vf);
    }


    /// <summary>
    /// Provides an interface for the gz_speed function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("gz_speed", 4, 1, 0)]
    protected void gz_speed(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("gz_speed", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object initialize_variables()
    {
      return mcr.EvaluateFunction("initialize_variables", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="N">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object initialize_variables(Object N)
    {
      return mcr.EvaluateFunction("initialize_variables", N);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object initialize_variables(Object N, Object M)
    {
      return mcr.EvaluateFunction("initialize_variables", N, M);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object initialize_variables(Object N, Object M, Object V)
    {
      return mcr.EvaluateFunction("initialize_variables", N, M, V);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object initialize_variables(Object N, Object M, Object V, Object min_range)
    {
      return mcr.EvaluateFunction("initialize_variables", N, M, V, min_range);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object initialize_variables(Object N, Object M, Object V, Object min_range, 
                                 Object max_range)
    {
      return mcr.EvaluateFunction("initialize_variables", N, M, V, min_range, max_range);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <param name="density0">Input argument #6</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object initialize_variables(Object N, Object M, Object V, Object min_range, 
                                 Object max_range, Object density0)
    {
      return mcr.EvaluateFunction("initialize_variables", N, M, V, min_range, max_range, density0);
    }


    /// <summary>
    /// Provides a single output, 7-input Objectinterface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <param name="density0">Input argument #6</param>
    /// <param name="input_flow">Input argument #7</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object initialize_variables(Object N, Object M, Object V, Object min_range, 
                                 Object max_range, Object density0, Object input_flow)
    {
      return mcr.EvaluateFunction("initialize_variables", N, M, V, min_range, max_range, density0, input_flow);
    }


    /// <summary>
    /// Provides a single output, 8-input Objectinterface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <param name="density0">Input argument #6</param>
    /// <param name="input_flow">Input argument #7</param>
    /// <param name="exit_density1">Input argument #8</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object initialize_variables(Object N, Object M, Object V, Object min_range, 
                                 Object max_range, Object density0, Object input_flow, 
                                 Object exit_density1)
    {
      return mcr.EvaluateFunction("initialize_variables", N, M, V, min_range, max_range, density0, input_flow, exit_density1);
    }


    /// <summary>
    /// Provides a single output, 9-input Objectinterface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <param name="density0">Input argument #6</param>
    /// <param name="input_flow">Input argument #7</param>
    /// <param name="exit_density1">Input argument #8</param>
    /// <param name="exit_ratio1">Input argument #9</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object initialize_variables(Object N, Object M, Object V, Object min_range, 
                                 Object max_range, Object density0, Object input_flow, 
                                 Object exit_density1, Object exit_ratio1)
    {
      return mcr.EvaluateFunction("initialize_variables", N, M, V, min_range, max_range, density0, input_flow, exit_density1, exit_ratio1);
    }


    /// <summary>
    /// Provides a single output, 10-input Objectinterface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <param name="density0">Input argument #6</param>
    /// <param name="input_flow">Input argument #7</param>
    /// <param name="exit_density1">Input argument #8</param>
    /// <param name="exit_ratio1">Input argument #9</param>
    /// <param name="enter_flow1">Input argument #10</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object initialize_variables(Object N, Object M, Object V, Object min_range, 
                                 Object max_range, Object density0, Object input_flow, 
                                 Object exit_density1, Object exit_ratio1, Object 
                                 enter_flow1)
    {
      return mcr.EvaluateFunction("initialize_variables", N, M, V, min_range, max_range, density0, input_flow, exit_density1, exit_ratio1, enter_flow1);
    }


    /// <summary>
    /// Provides a single output, 11-input Objectinterface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <param name="density0">Input argument #6</param>
    /// <param name="input_flow">Input argument #7</param>
    /// <param name="exit_density1">Input argument #8</param>
    /// <param name="exit_ratio1">Input argument #9</param>
    /// <param name="enter_flow1">Input argument #10</param>
    /// <param name="enter_ratio1">Input argument #11</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object initialize_variables(Object N, Object M, Object V, Object min_range, 
                                 Object max_range, Object density0, Object input_flow, 
                                 Object exit_density1, Object exit_ratio1, Object 
                                 enter_flow1, Object enter_ratio1)
    {
      return mcr.EvaluateFunction("initialize_variables", N, M, V, min_range, max_range, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1);
    }


    /// <summary>
    /// Provides a single output, 12-input Objectinterface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <param name="density0">Input argument #6</param>
    /// <param name="input_flow">Input argument #7</param>
    /// <param name="exit_density1">Input argument #8</param>
    /// <param name="exit_ratio1">Input argument #9</param>
    /// <param name="enter_flow1">Input argument #10</param>
    /// <param name="enter_ratio1">Input argument #11</param>
    /// <param name="enter_flow2">Input argument #12</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object initialize_variables(Object N, Object M, Object V, Object min_range, 
                                 Object max_range, Object density0, Object input_flow, 
                                 Object exit_density1, Object exit_ratio1, Object 
                                 enter_flow1, Object enter_ratio1, Object enter_flow2)
    {
      return mcr.EvaluateFunction("initialize_variables", N, M, V, min_range, max_range, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2);
    }


    /// <summary>
    /// Provides a single output, 13-input Objectinterface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <param name="density0">Input argument #6</param>
    /// <param name="input_flow">Input argument #7</param>
    /// <param name="exit_density1">Input argument #8</param>
    /// <param name="exit_ratio1">Input argument #9</param>
    /// <param name="enter_flow1">Input argument #10</param>
    /// <param name="enter_ratio1">Input argument #11</param>
    /// <param name="enter_flow2">Input argument #12</param>
    /// <param name="enter_ratio2">Input argument #13</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object initialize_variables(Object N, Object M, Object V, Object min_range, 
                                 Object max_range, Object density0, Object input_flow, 
                                 Object exit_density1, Object exit_ratio1, Object 
                                 enter_flow1, Object enter_ratio1, Object enter_flow2, 
                                 Object enter_ratio2)
    {
      return mcr.EvaluateFunction("initialize_variables", N, M, V, min_range, max_range, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2);
    }


    /// <summary>
    /// Provides a single output, 14-input Objectinterface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <param name="density0">Input argument #6</param>
    /// <param name="input_flow">Input argument #7</param>
    /// <param name="exit_density1">Input argument #8</param>
    /// <param name="exit_ratio1">Input argument #9</param>
    /// <param name="enter_flow1">Input argument #10</param>
    /// <param name="enter_ratio1">Input argument #11</param>
    /// <param name="enter_flow2">Input argument #12</param>
    /// <param name="enter_ratio2">Input argument #13</param>
    /// <param name="output_density">Input argument #14</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object initialize_variables(Object N, Object M, Object V, Object min_range, 
                                 Object max_range, Object density0, Object input_flow, 
                                 Object exit_density1, Object exit_ratio1, Object 
                                 enter_flow1, Object enter_ratio1, Object enter_flow2, 
                                 Object enter_ratio2, Object output_density)
    {
      return mcr.EvaluateFunction("initialize_variables", N, M, V, min_range, max_range, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density);
    }


    /// <summary>
    /// Provides a single output, 15-input Objectinterface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <param name="density0">Input argument #6</param>
    /// <param name="input_flow">Input argument #7</param>
    /// <param name="exit_density1">Input argument #8</param>
    /// <param name="exit_ratio1">Input argument #9</param>
    /// <param name="enter_flow1">Input argument #10</param>
    /// <param name="enter_ratio1">Input argument #11</param>
    /// <param name="enter_flow2">Input argument #12</param>
    /// <param name="enter_ratio2">Input argument #13</param>
    /// <param name="output_density">Input argument #14</param>
    /// <param name="flow_data">Input argument #15</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object initialize_variables(Object N, Object M, Object V, Object min_range, 
                                 Object max_range, Object density0, Object input_flow, 
                                 Object exit_density1, Object exit_ratio1, Object 
                                 enter_flow1, Object enter_ratio1, Object enter_flow2, 
                                 Object enter_ratio2, Object output_density, Object 
                                 flow_data)
    {
      return mcr.EvaluateFunction("initialize_variables", N, M, V, min_range, max_range, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data);
    }


    /// <summary>
    /// Provides a single output, 16-input Objectinterface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <param name="density0">Input argument #6</param>
    /// <param name="input_flow">Input argument #7</param>
    /// <param name="exit_density1">Input argument #8</param>
    /// <param name="exit_ratio1">Input argument #9</param>
    /// <param name="enter_flow1">Input argument #10</param>
    /// <param name="enter_ratio1">Input argument #11</param>
    /// <param name="enter_flow2">Input argument #12</param>
    /// <param name="enter_ratio2">Input argument #13</param>
    /// <param name="output_density">Input argument #14</param>
    /// <param name="flow_data">Input argument #15</param>
    /// <param name="speed_data">Input argument #16</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object initialize_variables(Object N, Object M, Object V, Object min_range, 
                                 Object max_range, Object density0, Object input_flow, 
                                 Object exit_density1, Object exit_ratio1, Object 
                                 enter_flow1, Object enter_ratio1, Object enter_flow2, 
                                 Object enter_ratio2, Object output_density, Object 
                                 flow_data, Object speed_data)
    {
      return mcr.EvaluateFunction("initialize_variables", N, M, V, min_range, max_range, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data, speed_data);
    }


    /// <summary>
    /// Provides a single output, 17-input Objectinterface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <param name="density0">Input argument #6</param>
    /// <param name="input_flow">Input argument #7</param>
    /// <param name="exit_density1">Input argument #8</param>
    /// <param name="exit_ratio1">Input argument #9</param>
    /// <param name="enter_flow1">Input argument #10</param>
    /// <param name="enter_ratio1">Input argument #11</param>
    /// <param name="enter_flow2">Input argument #12</param>
    /// <param name="enter_ratio2">Input argument #13</param>
    /// <param name="output_density">Input argument #14</param>
    /// <param name="flow_data">Input argument #15</param>
    /// <param name="speed_data">Input argument #16</param>
    /// <param name="hours">Input argument #17</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object initialize_variables(Object N, Object M, Object V, Object min_range, 
                                 Object max_range, Object density0, Object input_flow, 
                                 Object exit_density1, Object exit_ratio1, Object 
                                 enter_flow1, Object enter_ratio1, Object enter_flow2, 
                                 Object enter_ratio2, Object output_density, Object 
                                 flow_data, Object speed_data, Object hours)
    {
      return mcr.EvaluateFunction("initialize_variables", N, M, V, min_range, max_range, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data, speed_data, hours);
    }


    /// <summary>
    /// Provides a single output, 18-input Objectinterface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <param name="density0">Input argument #6</param>
    /// <param name="input_flow">Input argument #7</param>
    /// <param name="exit_density1">Input argument #8</param>
    /// <param name="exit_ratio1">Input argument #9</param>
    /// <param name="enter_flow1">Input argument #10</param>
    /// <param name="enter_ratio1">Input argument #11</param>
    /// <param name="enter_flow2">Input argument #12</param>
    /// <param name="enter_ratio2">Input argument #13</param>
    /// <param name="output_density">Input argument #14</param>
    /// <param name="flow_data">Input argument #15</param>
    /// <param name="speed_data">Input argument #16</param>
    /// <param name="hours">Input argument #17</param>
    /// <param name="varargin">Array of Objects representing the input arguments 18
    /// through varargin.length+17</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object initialize_variables(Object N, Object M, Object V, Object min_range, 
                                 Object max_range, Object density0, Object input_flow, 
                                 Object exit_density1, Object exit_ratio1, Object 
                                 enter_flow1, Object enter_ratio1, Object enter_flow2, 
                                 Object enter_ratio2, Object output_density, Object 
                                 flow_data, Object speed_data, Object hours, params 
                                 Object[] varargin)
    {
      Object[] argsIn= {N, M, V, min_range, max_range, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data, speed_data, hours, varargin};

      return mcr.EvaluateFunction("initialize_variables", argsIn);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the initialize_variables MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] initialize_variables(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "initialize_variables", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the initialize_variables MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="N">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] initialize_variables(int numArgsOut, Object N)
    {
      return mcr.EvaluateFunction(numArgsOut, "initialize_variables", N);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the initialize_variables MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] initialize_variables(int numArgsOut, Object N, Object M)
    {
      return mcr.EvaluateFunction(numArgsOut, "initialize_variables", N, M);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the initialize_variables MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] initialize_variables(int numArgsOut, Object N, Object M, Object V)
    {
      return mcr.EvaluateFunction(numArgsOut, "initialize_variables", N, M, V);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the initialize_variables MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] initialize_variables(int numArgsOut, Object N, Object M, Object V, 
                                   Object min_range)
    {
      return mcr.EvaluateFunction(numArgsOut, "initialize_variables", N, M, V, min_range);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the initialize_variables MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] initialize_variables(int numArgsOut, Object N, Object M, Object V, 
                                   Object min_range, Object max_range)
    {
      return mcr.EvaluateFunction(numArgsOut, "initialize_variables", N, M, V, min_range, max_range);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the initialize_variables MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <param name="density0">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] initialize_variables(int numArgsOut, Object N, Object M, Object V, 
                                   Object min_range, Object max_range, Object density0)
    {
      return mcr.EvaluateFunction(numArgsOut, "initialize_variables", N, M, V, min_range, max_range, density0);
    }


    /// <summary>
    /// Provides the standard 7-input Object interface to the initialize_variables MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <param name="density0">Input argument #6</param>
    /// <param name="input_flow">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] initialize_variables(int numArgsOut, Object N, Object M, Object V, 
                                   Object min_range, Object max_range, Object density0, 
                                   Object input_flow)
    {
      return mcr.EvaluateFunction(numArgsOut, "initialize_variables", N, M, V, min_range, max_range, density0, input_flow);
    }


    /// <summary>
    /// Provides the standard 8-input Object interface to the initialize_variables MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <param name="density0">Input argument #6</param>
    /// <param name="input_flow">Input argument #7</param>
    /// <param name="exit_density1">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] initialize_variables(int numArgsOut, Object N, Object M, Object V, 
                                   Object min_range, Object max_range, Object density0, 
                                   Object input_flow, Object exit_density1)
    {
      return mcr.EvaluateFunction(numArgsOut, "initialize_variables", N, M, V, min_range, max_range, density0, input_flow, exit_density1);
    }


    /// <summary>
    /// Provides the standard 9-input Object interface to the initialize_variables MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <param name="density0">Input argument #6</param>
    /// <param name="input_flow">Input argument #7</param>
    /// <param name="exit_density1">Input argument #8</param>
    /// <param name="exit_ratio1">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] initialize_variables(int numArgsOut, Object N, Object M, Object V, 
                                   Object min_range, Object max_range, Object density0, 
                                   Object input_flow, Object exit_density1, Object 
                                   exit_ratio1)
    {
      return mcr.EvaluateFunction(numArgsOut, "initialize_variables", N, M, V, min_range, max_range, density0, input_flow, exit_density1, exit_ratio1);
    }


    /// <summary>
    /// Provides the standard 10-input Object interface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <param name="density0">Input argument #6</param>
    /// <param name="input_flow">Input argument #7</param>
    /// <param name="exit_density1">Input argument #8</param>
    /// <param name="exit_ratio1">Input argument #9</param>
    /// <param name="enter_flow1">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] initialize_variables(int numArgsOut, Object N, Object M, Object V, 
                                   Object min_range, Object max_range, Object density0, 
                                   Object input_flow, Object exit_density1, Object 
                                   exit_ratio1, Object enter_flow1)
    {
      return mcr.EvaluateFunction(numArgsOut, "initialize_variables", N, M, V, min_range, max_range, density0, input_flow, exit_density1, exit_ratio1, enter_flow1);
    }


    /// <summary>
    /// Provides the standard 11-input Object interface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <param name="density0">Input argument #6</param>
    /// <param name="input_flow">Input argument #7</param>
    /// <param name="exit_density1">Input argument #8</param>
    /// <param name="exit_ratio1">Input argument #9</param>
    /// <param name="enter_flow1">Input argument #10</param>
    /// <param name="enter_ratio1">Input argument #11</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] initialize_variables(int numArgsOut, Object N, Object M, Object V, 
                                   Object min_range, Object max_range, Object density0, 
                                   Object input_flow, Object exit_density1, Object 
                                   exit_ratio1, Object enter_flow1, Object enter_ratio1)
    {
      return mcr.EvaluateFunction(numArgsOut, "initialize_variables", N, M, V, min_range, max_range, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1);
    }


    /// <summary>
    /// Provides the standard 12-input Object interface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <param name="density0">Input argument #6</param>
    /// <param name="input_flow">Input argument #7</param>
    /// <param name="exit_density1">Input argument #8</param>
    /// <param name="exit_ratio1">Input argument #9</param>
    /// <param name="enter_flow1">Input argument #10</param>
    /// <param name="enter_ratio1">Input argument #11</param>
    /// <param name="enter_flow2">Input argument #12</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] initialize_variables(int numArgsOut, Object N, Object M, Object V, 
                                   Object min_range, Object max_range, Object density0, 
                                   Object input_flow, Object exit_density1, Object 
                                   exit_ratio1, Object enter_flow1, Object enter_ratio1, 
                                   Object enter_flow2)
    {
      return mcr.EvaluateFunction(numArgsOut, "initialize_variables", N, M, V, min_range, max_range, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2);
    }


    /// <summary>
    /// Provides the standard 13-input Object interface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <param name="density0">Input argument #6</param>
    /// <param name="input_flow">Input argument #7</param>
    /// <param name="exit_density1">Input argument #8</param>
    /// <param name="exit_ratio1">Input argument #9</param>
    /// <param name="enter_flow1">Input argument #10</param>
    /// <param name="enter_ratio1">Input argument #11</param>
    /// <param name="enter_flow2">Input argument #12</param>
    /// <param name="enter_ratio2">Input argument #13</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] initialize_variables(int numArgsOut, Object N, Object M, Object V, 
                                   Object min_range, Object max_range, Object density0, 
                                   Object input_flow, Object exit_density1, Object 
                                   exit_ratio1, Object enter_flow1, Object enter_ratio1, 
                                   Object enter_flow2, Object enter_ratio2)
    {
      return mcr.EvaluateFunction(numArgsOut, "initialize_variables", N, M, V, min_range, max_range, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2);
    }


    /// <summary>
    /// Provides the standard 14-input Object interface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <param name="density0">Input argument #6</param>
    /// <param name="input_flow">Input argument #7</param>
    /// <param name="exit_density1">Input argument #8</param>
    /// <param name="exit_ratio1">Input argument #9</param>
    /// <param name="enter_flow1">Input argument #10</param>
    /// <param name="enter_ratio1">Input argument #11</param>
    /// <param name="enter_flow2">Input argument #12</param>
    /// <param name="enter_ratio2">Input argument #13</param>
    /// <param name="output_density">Input argument #14</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] initialize_variables(int numArgsOut, Object N, Object M, Object V, 
                                   Object min_range, Object max_range, Object density0, 
                                   Object input_flow, Object exit_density1, Object 
                                   exit_ratio1, Object enter_flow1, Object enter_ratio1, 
                                   Object enter_flow2, Object enter_ratio2, Object 
                                   output_density)
    {
      return mcr.EvaluateFunction(numArgsOut, "initialize_variables", N, M, V, min_range, max_range, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density);
    }


    /// <summary>
    /// Provides the standard 15-input Object interface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <param name="density0">Input argument #6</param>
    /// <param name="input_flow">Input argument #7</param>
    /// <param name="exit_density1">Input argument #8</param>
    /// <param name="exit_ratio1">Input argument #9</param>
    /// <param name="enter_flow1">Input argument #10</param>
    /// <param name="enter_ratio1">Input argument #11</param>
    /// <param name="enter_flow2">Input argument #12</param>
    /// <param name="enter_ratio2">Input argument #13</param>
    /// <param name="output_density">Input argument #14</param>
    /// <param name="flow_data">Input argument #15</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] initialize_variables(int numArgsOut, Object N, Object M, Object V, 
                                   Object min_range, Object max_range, Object density0, 
                                   Object input_flow, Object exit_density1, Object 
                                   exit_ratio1, Object enter_flow1, Object enter_ratio1, 
                                   Object enter_flow2, Object enter_ratio2, Object 
                                   output_density, Object flow_data)
    {
      return mcr.EvaluateFunction(numArgsOut, "initialize_variables", N, M, V, min_range, max_range, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data);
    }


    /// <summary>
    /// Provides the standard 16-input Object interface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <param name="density0">Input argument #6</param>
    /// <param name="input_flow">Input argument #7</param>
    /// <param name="exit_density1">Input argument #8</param>
    /// <param name="exit_ratio1">Input argument #9</param>
    /// <param name="enter_flow1">Input argument #10</param>
    /// <param name="enter_ratio1">Input argument #11</param>
    /// <param name="enter_flow2">Input argument #12</param>
    /// <param name="enter_ratio2">Input argument #13</param>
    /// <param name="output_density">Input argument #14</param>
    /// <param name="flow_data">Input argument #15</param>
    /// <param name="speed_data">Input argument #16</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] initialize_variables(int numArgsOut, Object N, Object M, Object V, 
                                   Object min_range, Object max_range, Object density0, 
                                   Object input_flow, Object exit_density1, Object 
                                   exit_ratio1, Object enter_flow1, Object enter_ratio1, 
                                   Object enter_flow2, Object enter_ratio2, Object 
                                   output_density, Object flow_data, Object speed_data)
    {
      return mcr.EvaluateFunction(numArgsOut, "initialize_variables", N, M, V, min_range, max_range, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data, speed_data);
    }


    /// <summary>
    /// Provides the standard 17-input Object interface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <param name="density0">Input argument #6</param>
    /// <param name="input_flow">Input argument #7</param>
    /// <param name="exit_density1">Input argument #8</param>
    /// <param name="exit_ratio1">Input argument #9</param>
    /// <param name="enter_flow1">Input argument #10</param>
    /// <param name="enter_ratio1">Input argument #11</param>
    /// <param name="enter_flow2">Input argument #12</param>
    /// <param name="enter_ratio2">Input argument #13</param>
    /// <param name="output_density">Input argument #14</param>
    /// <param name="flow_data">Input argument #15</param>
    /// <param name="speed_data">Input argument #16</param>
    /// <param name="hours">Input argument #17</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] initialize_variables(int numArgsOut, Object N, Object M, Object V, 
                                   Object min_range, Object max_range, Object density0, 
                                   Object input_flow, Object exit_density1, Object 
                                   exit_ratio1, Object enter_flow1, Object enter_ratio1, 
                                   Object enter_flow2, Object enter_ratio2, Object 
                                   output_density, Object flow_data, Object speed_data, 
                                   Object hours)
    {
      return mcr.EvaluateFunction(numArgsOut, "initialize_variables", N, M, V, min_range, max_range, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data, speed_data, hours);
    }


    /// <summary>
    /// Provides the standard 18-input Object interface to the initialize_variables
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="min_range">Input argument #4</param>
    /// <param name="max_range">Input argument #5</param>
    /// <param name="density0">Input argument #6</param>
    /// <param name="input_flow">Input argument #7</param>
    /// <param name="exit_density1">Input argument #8</param>
    /// <param name="exit_ratio1">Input argument #9</param>
    /// <param name="enter_flow1">Input argument #10</param>
    /// <param name="enter_ratio1">Input argument #11</param>
    /// <param name="enter_flow2">Input argument #12</param>
    /// <param name="enter_ratio2">Input argument #13</param>
    /// <param name="output_density">Input argument #14</param>
    /// <param name="flow_data">Input argument #15</param>
    /// <param name="speed_data">Input argument #16</param>
    /// <param name="hours">Input argument #17</param>
    /// <param name="varargin">Array of Objects representing the input arguments 18
    /// through varargin.length+17</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] initialize_variables(int numArgsOut, Object N, Object M, Object V, 
                                   Object min_range, Object max_range, Object density0, 
                                   Object input_flow, Object exit_density1, Object 
                                   exit_ratio1, Object enter_flow1, Object enter_ratio1, 
                                   Object enter_flow2, Object enter_ratio2, Object 
                                   output_density, Object flow_data, Object speed_data, 
                                   Object hours, params Object[] varargin)
    {
      Object[] argsIn= {N, M, V, min_range, max_range, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data, speed_data, hours, varargin};

      return mcr.EvaluateFunction(numArgsOut, "initialize_variables", argsIn);
    }


    /// <summary>
    /// Provides an interface for the initialize_variables function in which the input
    /// and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// function f = initialize_variables(N, M, V, min_tange, max_range) 
    /// This function initializes the chromosomes. Each chromosome has the
    /// following at this stage
    /// * set of decision variables
    /// * objective function values
    /// where,
    /// N - Population size
    /// M - Number of objective functions
    /// V - Number of decision variables
    /// min_range - A vector of decimal values which indicate the minimum value
    /// for each decision variable.
    /// max_range - Vector of maximum possible values for decision variables.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("initialize_variables", 17, 1, 1)]
    protected void initialize_variables(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("initialize_variables", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the non_domination_sort_mod
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = non_domination_sort_mod(x, M, V)
    /// This function sort the current popultion based on non-domination. All the
    /// individuals in the first front are given a rank of 1, the second front
    /// individuals are assigned rank 2 and so on. After assigning the rank the
    /// crowding in each front is calculated.
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object non_domination_sort_mod()
    {
      return mcr.EvaluateFunction("non_domination_sort_mod", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the non_domination_sort_mod
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = non_domination_sort_mod(x, M, V)
    /// This function sort the current popultion based on non-domination. All the
    /// individuals in the first front are given a rank of 1, the second front
    /// individuals are assigned rank 2 and so on. After assigning the rank the
    /// crowding in each front is calculated.
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object non_domination_sort_mod(Object x)
    {
      return mcr.EvaluateFunction("non_domination_sort_mod", x);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the non_domination_sort_mod
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = non_domination_sort_mod(x, M, V)
    /// This function sort the current popultion based on non-domination. All the
    /// individuals in the first front are given a rank of 1, the second front
    /// individuals are assigned rank 2 and so on. After assigning the rank the
    /// crowding in each front is calculated.
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object non_domination_sort_mod(Object x, Object M)
    {
      return mcr.EvaluateFunction("non_domination_sort_mod", x, M);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the non_domination_sort_mod
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = non_domination_sort_mod(x, M, V)
    /// This function sort the current popultion based on non-domination. All the
    /// individuals in the first front are given a rank of 1, the second front
    /// individuals are assigned rank 2 and so on. After assigning the rank the
    /// crowding in each front is calculated.
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object non_domination_sort_mod(Object x, Object M, Object V)
    {
      return mcr.EvaluateFunction("non_domination_sort_mod", x, M, V);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the non_domination_sort_mod
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = non_domination_sort_mod(x, M, V)
    /// This function sort the current popultion based on non-domination. All the
    /// individuals in the first front are given a rank of 1, the second front
    /// individuals are assigned rank 2 and so on. After assigning the rank the
    /// crowding in each front is calculated.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] non_domination_sort_mod(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "non_domination_sort_mod", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the non_domination_sort_mod
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = non_domination_sort_mod(x, M, V)
    /// This function sort the current popultion based on non-domination. All the
    /// individuals in the first front are given a rank of 1, the second front
    /// individuals are assigned rank 2 and so on. After assigning the rank the
    /// crowding in each front is calculated.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] non_domination_sort_mod(int numArgsOut, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "non_domination_sort_mod", x);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the non_domination_sort_mod
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = non_domination_sort_mod(x, M, V)
    /// This function sort the current popultion based on non-domination. All the
    /// individuals in the first front are given a rank of 1, the second front
    /// individuals are assigned rank 2 and so on. After assigning the rank the
    /// crowding in each front is calculated.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] non_domination_sort_mod(int numArgsOut, Object x, Object M)
    {
      return mcr.EvaluateFunction(numArgsOut, "non_domination_sort_mod", x, M);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the non_domination_sort_mod
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f = non_domination_sort_mod(x, M, V)
    /// This function sort the current popultion based on non-domination. All the
    /// individuals in the first front are given a rank of 1, the second front
    /// individuals are assigned rank 2 and so on. After assigning the rank the
    /// crowding in each front is calculated.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] non_domination_sort_mod(int numArgsOut, Object x, Object M, Object V)
    {
      return mcr.EvaluateFunction(numArgsOut, "non_domination_sort_mod", x, M, V);
    }


    /// <summary>
    /// Provides an interface for the non_domination_sort_mod function in which the input
    /// and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// function f = non_domination_sort_mod(x, M, V)
    /// This function sort the current popultion based on non-domination. All the
    /// individuals in the first front are given a rank of 1, the second front
    /// individuals are assigned rank 2 and so on. After assigning the rank the
    /// crowding in each front is calculated.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("non_domination_sort_mod", 3, 1, 0)]
    protected void non_domination_sort_mod(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("non_domination_sort_mod", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object nsga_2()
    {
      return mcr.EvaluateFunction("nsga_2", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="pop">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object nsga_2(Object pop)
    {
      return mcr.EvaluateFunction("nsga_2", pop);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object nsga_2(Object pop, Object gen)
    {
      return mcr.EvaluateFunction("nsga_2", pop, gen);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <param name="density0">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object nsga_2(Object pop, Object gen, Object density0)
    {
      return mcr.EvaluateFunction("nsga_2", pop, gen, density0);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <param name="density0">Input argument #3</param>
    /// <param name="input_flow">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object nsga_2(Object pop, Object gen, Object density0, Object input_flow)
    {
      return mcr.EvaluateFunction("nsga_2", pop, gen, density0, input_flow);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <param name="density0">Input argument #3</param>
    /// <param name="input_flow">Input argument #4</param>
    /// <param name="exit_density1">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object nsga_2(Object pop, Object gen, Object density0, Object input_flow, 
                   Object exit_density1)
    {
      return mcr.EvaluateFunction("nsga_2", pop, gen, density0, input_flow, exit_density1);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <param name="density0">Input argument #3</param>
    /// <param name="input_flow">Input argument #4</param>
    /// <param name="exit_density1">Input argument #5</param>
    /// <param name="exit_ratio1">Input argument #6</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object nsga_2(Object pop, Object gen, Object density0, Object input_flow, 
                   Object exit_density1, Object exit_ratio1)
    {
      return mcr.EvaluateFunction("nsga_2", pop, gen, density0, input_flow, exit_density1, exit_ratio1);
    }


    /// <summary>
    /// Provides a single output, 7-input Objectinterface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <param name="density0">Input argument #3</param>
    /// <param name="input_flow">Input argument #4</param>
    /// <param name="exit_density1">Input argument #5</param>
    /// <param name="exit_ratio1">Input argument #6</param>
    /// <param name="enter_flow1">Input argument #7</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object nsga_2(Object pop, Object gen, Object density0, Object input_flow, 
                   Object exit_density1, Object exit_ratio1, Object enter_flow1)
    {
      return mcr.EvaluateFunction("nsga_2", pop, gen, density0, input_flow, exit_density1, exit_ratio1, enter_flow1);
    }


    /// <summary>
    /// Provides a single output, 8-input Objectinterface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <param name="density0">Input argument #3</param>
    /// <param name="input_flow">Input argument #4</param>
    /// <param name="exit_density1">Input argument #5</param>
    /// <param name="exit_ratio1">Input argument #6</param>
    /// <param name="enter_flow1">Input argument #7</param>
    /// <param name="enter_ratio1">Input argument #8</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object nsga_2(Object pop, Object gen, Object density0, Object input_flow, 
                   Object exit_density1, Object exit_ratio1, Object enter_flow1, Object 
                   enter_ratio1)
    {
      return mcr.EvaluateFunction("nsga_2", pop, gen, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1);
    }


    /// <summary>
    /// Provides a single output, 9-input Objectinterface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <param name="density0">Input argument #3</param>
    /// <param name="input_flow">Input argument #4</param>
    /// <param name="exit_density1">Input argument #5</param>
    /// <param name="exit_ratio1">Input argument #6</param>
    /// <param name="enter_flow1">Input argument #7</param>
    /// <param name="enter_ratio1">Input argument #8</param>
    /// <param name="enter_flow2">Input argument #9</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object nsga_2(Object pop, Object gen, Object density0, Object input_flow, 
                   Object exit_density1, Object exit_ratio1, Object enter_flow1, Object 
                   enter_ratio1, Object enter_flow2)
    {
      return mcr.EvaluateFunction("nsga_2", pop, gen, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2);
    }


    /// <summary>
    /// Provides a single output, 10-input Objectinterface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <param name="density0">Input argument #3</param>
    /// <param name="input_flow">Input argument #4</param>
    /// <param name="exit_density1">Input argument #5</param>
    /// <param name="exit_ratio1">Input argument #6</param>
    /// <param name="enter_flow1">Input argument #7</param>
    /// <param name="enter_ratio1">Input argument #8</param>
    /// <param name="enter_flow2">Input argument #9</param>
    /// <param name="enter_ratio2">Input argument #10</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object nsga_2(Object pop, Object gen, Object density0, Object input_flow, 
                   Object exit_density1, Object exit_ratio1, Object enter_flow1, Object 
                   enter_ratio1, Object enter_flow2, Object enter_ratio2)
    {
      return mcr.EvaluateFunction("nsga_2", pop, gen, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2);
    }


    /// <summary>
    /// Provides a single output, 11-input Objectinterface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <param name="density0">Input argument #3</param>
    /// <param name="input_flow">Input argument #4</param>
    /// <param name="exit_density1">Input argument #5</param>
    /// <param name="exit_ratio1">Input argument #6</param>
    /// <param name="enter_flow1">Input argument #7</param>
    /// <param name="enter_ratio1">Input argument #8</param>
    /// <param name="enter_flow2">Input argument #9</param>
    /// <param name="enter_ratio2">Input argument #10</param>
    /// <param name="output_density">Input argument #11</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object nsga_2(Object pop, Object gen, Object density0, Object input_flow, 
                   Object exit_density1, Object exit_ratio1, Object enter_flow1, Object 
                   enter_ratio1, Object enter_flow2, Object enter_ratio2, Object 
                   output_density)
    {
      return mcr.EvaluateFunction("nsga_2", pop, gen, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density);
    }


    /// <summary>
    /// Provides a single output, 12-input Objectinterface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <param name="density0">Input argument #3</param>
    /// <param name="input_flow">Input argument #4</param>
    /// <param name="exit_density1">Input argument #5</param>
    /// <param name="exit_ratio1">Input argument #6</param>
    /// <param name="enter_flow1">Input argument #7</param>
    /// <param name="enter_ratio1">Input argument #8</param>
    /// <param name="enter_flow2">Input argument #9</param>
    /// <param name="enter_ratio2">Input argument #10</param>
    /// <param name="output_density">Input argument #11</param>
    /// <param name="flow_data">Input argument #12</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object nsga_2(Object pop, Object gen, Object density0, Object input_flow, 
                   Object exit_density1, Object exit_ratio1, Object enter_flow1, Object 
                   enter_ratio1, Object enter_flow2, Object enter_ratio2, Object 
                   output_density, Object flow_data)
    {
      return mcr.EvaluateFunction("nsga_2", pop, gen, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data);
    }


    /// <summary>
    /// Provides a single output, 13-input Objectinterface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <param name="density0">Input argument #3</param>
    /// <param name="input_flow">Input argument #4</param>
    /// <param name="exit_density1">Input argument #5</param>
    /// <param name="exit_ratio1">Input argument #6</param>
    /// <param name="enter_flow1">Input argument #7</param>
    /// <param name="enter_ratio1">Input argument #8</param>
    /// <param name="enter_flow2">Input argument #9</param>
    /// <param name="enter_ratio2">Input argument #10</param>
    /// <param name="output_density">Input argument #11</param>
    /// <param name="flow_data">Input argument #12</param>
    /// <param name="speed_data">Input argument #13</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object nsga_2(Object pop, Object gen, Object density0, Object input_flow, 
                   Object exit_density1, Object exit_ratio1, Object enter_flow1, Object 
                   enter_ratio1, Object enter_flow2, Object enter_ratio2, Object 
                   output_density, Object flow_data, Object speed_data)
    {
      return mcr.EvaluateFunction("nsga_2", pop, gen, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data, speed_data);
    }


    /// <summary>
    /// Provides a single output, 14-input Objectinterface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <param name="density0">Input argument #3</param>
    /// <param name="input_flow">Input argument #4</param>
    /// <param name="exit_density1">Input argument #5</param>
    /// <param name="exit_ratio1">Input argument #6</param>
    /// <param name="enter_flow1">Input argument #7</param>
    /// <param name="enter_ratio1">Input argument #8</param>
    /// <param name="enter_flow2">Input argument #9</param>
    /// <param name="enter_ratio2">Input argument #10</param>
    /// <param name="output_density">Input argument #11</param>
    /// <param name="flow_data">Input argument #12</param>
    /// <param name="speed_data">Input argument #13</param>
    /// <param name="hours">Input argument #14</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object nsga_2(Object pop, Object gen, Object density0, Object input_flow, 
                   Object exit_density1, Object exit_ratio1, Object enter_flow1, Object 
                   enter_ratio1, Object enter_flow2, Object enter_ratio2, Object 
                   output_density, Object flow_data, Object speed_data, Object hours)
    {
      return mcr.EvaluateFunction("nsga_2", pop, gen, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data, speed_data, hours);
    }


    /// <summary>
    /// Provides a single output, 15-input Objectinterface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <param name="density0">Input argument #3</param>
    /// <param name="input_flow">Input argument #4</param>
    /// <param name="exit_density1">Input argument #5</param>
    /// <param name="exit_ratio1">Input argument #6</param>
    /// <param name="enter_flow1">Input argument #7</param>
    /// <param name="enter_ratio1">Input argument #8</param>
    /// <param name="enter_flow2">Input argument #9</param>
    /// <param name="enter_ratio2">Input argument #10</param>
    /// <param name="output_density">Input argument #11</param>
    /// <param name="flow_data">Input argument #12</param>
    /// <param name="speed_data">Input argument #13</param>
    /// <param name="hours">Input argument #14</param>
    /// <param name="varargin">Array of Objects representing the input arguments 15
    /// through varargin.length+14</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object nsga_2(Object pop, Object gen, Object density0, Object input_flow, 
                   Object exit_density1, Object exit_ratio1, Object enter_flow1, Object 
                   enter_ratio1, Object enter_flow2, Object enter_ratio2, Object 
                   output_density, Object flow_data, Object speed_data, Object hours, 
                   params Object[] varargin)
    {
      Object[] argsIn= {pop, gen, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data, speed_data, hours, varargin};

      return mcr.EvaluateFunction("nsga_2", argsIn);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] nsga_2(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "nsga_2", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="pop">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] nsga_2(int numArgsOut, Object pop)
    {
      return mcr.EvaluateFunction(numArgsOut, "nsga_2", pop);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] nsga_2(int numArgsOut, Object pop, Object gen)
    {
      return mcr.EvaluateFunction(numArgsOut, "nsga_2", pop, gen);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <param name="density0">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] nsga_2(int numArgsOut, Object pop, Object gen, Object density0)
    {
      return mcr.EvaluateFunction(numArgsOut, "nsga_2", pop, gen, density0);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <param name="density0">Input argument #3</param>
    /// <param name="input_flow">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] nsga_2(int numArgsOut, Object pop, Object gen, Object density0, 
                     Object input_flow)
    {
      return mcr.EvaluateFunction(numArgsOut, "nsga_2", pop, gen, density0, input_flow);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <param name="density0">Input argument #3</param>
    /// <param name="input_flow">Input argument #4</param>
    /// <param name="exit_density1">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] nsga_2(int numArgsOut, Object pop, Object gen, Object density0, 
                     Object input_flow, Object exit_density1)
    {
      return mcr.EvaluateFunction(numArgsOut, "nsga_2", pop, gen, density0, input_flow, exit_density1);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <param name="density0">Input argument #3</param>
    /// <param name="input_flow">Input argument #4</param>
    /// <param name="exit_density1">Input argument #5</param>
    /// <param name="exit_ratio1">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] nsga_2(int numArgsOut, Object pop, Object gen, Object density0, 
                     Object input_flow, Object exit_density1, Object exit_ratio1)
    {
      return mcr.EvaluateFunction(numArgsOut, "nsga_2", pop, gen, density0, input_flow, exit_density1, exit_ratio1);
    }


    /// <summary>
    /// Provides the standard 7-input Object interface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <param name="density0">Input argument #3</param>
    /// <param name="input_flow">Input argument #4</param>
    /// <param name="exit_density1">Input argument #5</param>
    /// <param name="exit_ratio1">Input argument #6</param>
    /// <param name="enter_flow1">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] nsga_2(int numArgsOut, Object pop, Object gen, Object density0, 
                     Object input_flow, Object exit_density1, Object exit_ratio1, Object 
                     enter_flow1)
    {
      return mcr.EvaluateFunction(numArgsOut, "nsga_2", pop, gen, density0, input_flow, exit_density1, exit_ratio1, enter_flow1);
    }


    /// <summary>
    /// Provides the standard 8-input Object interface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <param name="density0">Input argument #3</param>
    /// <param name="input_flow">Input argument #4</param>
    /// <param name="exit_density1">Input argument #5</param>
    /// <param name="exit_ratio1">Input argument #6</param>
    /// <param name="enter_flow1">Input argument #7</param>
    /// <param name="enter_ratio1">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] nsga_2(int numArgsOut, Object pop, Object gen, Object density0, 
                     Object input_flow, Object exit_density1, Object exit_ratio1, Object 
                     enter_flow1, Object enter_ratio1)
    {
      return mcr.EvaluateFunction(numArgsOut, "nsga_2", pop, gen, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1);
    }


    /// <summary>
    /// Provides the standard 9-input Object interface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <param name="density0">Input argument #3</param>
    /// <param name="input_flow">Input argument #4</param>
    /// <param name="exit_density1">Input argument #5</param>
    /// <param name="exit_ratio1">Input argument #6</param>
    /// <param name="enter_flow1">Input argument #7</param>
    /// <param name="enter_ratio1">Input argument #8</param>
    /// <param name="enter_flow2">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] nsga_2(int numArgsOut, Object pop, Object gen, Object density0, 
                     Object input_flow, Object exit_density1, Object exit_ratio1, Object 
                     enter_flow1, Object enter_ratio1, Object enter_flow2)
    {
      return mcr.EvaluateFunction(numArgsOut, "nsga_2", pop, gen, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2);
    }


    /// <summary>
    /// Provides the standard 10-input Object interface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <param name="density0">Input argument #3</param>
    /// <param name="input_flow">Input argument #4</param>
    /// <param name="exit_density1">Input argument #5</param>
    /// <param name="exit_ratio1">Input argument #6</param>
    /// <param name="enter_flow1">Input argument #7</param>
    /// <param name="enter_ratio1">Input argument #8</param>
    /// <param name="enter_flow2">Input argument #9</param>
    /// <param name="enter_ratio2">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] nsga_2(int numArgsOut, Object pop, Object gen, Object density0, 
                     Object input_flow, Object exit_density1, Object exit_ratio1, Object 
                     enter_flow1, Object enter_ratio1, Object enter_flow2, Object 
                     enter_ratio2)
    {
      return mcr.EvaluateFunction(numArgsOut, "nsga_2", pop, gen, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2);
    }


    /// <summary>
    /// Provides the standard 11-input Object interface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <param name="density0">Input argument #3</param>
    /// <param name="input_flow">Input argument #4</param>
    /// <param name="exit_density1">Input argument #5</param>
    /// <param name="exit_ratio1">Input argument #6</param>
    /// <param name="enter_flow1">Input argument #7</param>
    /// <param name="enter_ratio1">Input argument #8</param>
    /// <param name="enter_flow2">Input argument #9</param>
    /// <param name="enter_ratio2">Input argument #10</param>
    /// <param name="output_density">Input argument #11</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] nsga_2(int numArgsOut, Object pop, Object gen, Object density0, 
                     Object input_flow, Object exit_density1, Object exit_ratio1, Object 
                     enter_flow1, Object enter_ratio1, Object enter_flow2, Object 
                     enter_ratio2, Object output_density)
    {
      return mcr.EvaluateFunction(numArgsOut, "nsga_2", pop, gen, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density);
    }


    /// <summary>
    /// Provides the standard 12-input Object interface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <param name="density0">Input argument #3</param>
    /// <param name="input_flow">Input argument #4</param>
    /// <param name="exit_density1">Input argument #5</param>
    /// <param name="exit_ratio1">Input argument #6</param>
    /// <param name="enter_flow1">Input argument #7</param>
    /// <param name="enter_ratio1">Input argument #8</param>
    /// <param name="enter_flow2">Input argument #9</param>
    /// <param name="enter_ratio2">Input argument #10</param>
    /// <param name="output_density">Input argument #11</param>
    /// <param name="flow_data">Input argument #12</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] nsga_2(int numArgsOut, Object pop, Object gen, Object density0, 
                     Object input_flow, Object exit_density1, Object exit_ratio1, Object 
                     enter_flow1, Object enter_ratio1, Object enter_flow2, Object 
                     enter_ratio2, Object output_density, Object flow_data)
    {
      return mcr.EvaluateFunction(numArgsOut, "nsga_2", pop, gen, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data);
    }


    /// <summary>
    /// Provides the standard 13-input Object interface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <param name="density0">Input argument #3</param>
    /// <param name="input_flow">Input argument #4</param>
    /// <param name="exit_density1">Input argument #5</param>
    /// <param name="exit_ratio1">Input argument #6</param>
    /// <param name="enter_flow1">Input argument #7</param>
    /// <param name="enter_ratio1">Input argument #8</param>
    /// <param name="enter_flow2">Input argument #9</param>
    /// <param name="enter_ratio2">Input argument #10</param>
    /// <param name="output_density">Input argument #11</param>
    /// <param name="flow_data">Input argument #12</param>
    /// <param name="speed_data">Input argument #13</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] nsga_2(int numArgsOut, Object pop, Object gen, Object density0, 
                     Object input_flow, Object exit_density1, Object exit_ratio1, Object 
                     enter_flow1, Object enter_ratio1, Object enter_flow2, Object 
                     enter_ratio2, Object output_density, Object flow_data, Object 
                     speed_data)
    {
      return mcr.EvaluateFunction(numArgsOut, "nsga_2", pop, gen, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data, speed_data);
    }


    /// <summary>
    /// Provides the standard 14-input Object interface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <param name="density0">Input argument #3</param>
    /// <param name="input_flow">Input argument #4</param>
    /// <param name="exit_density1">Input argument #5</param>
    /// <param name="exit_ratio1">Input argument #6</param>
    /// <param name="enter_flow1">Input argument #7</param>
    /// <param name="enter_ratio1">Input argument #8</param>
    /// <param name="enter_flow2">Input argument #9</param>
    /// <param name="enter_ratio2">Input argument #10</param>
    /// <param name="output_density">Input argument #11</param>
    /// <param name="flow_data">Input argument #12</param>
    /// <param name="speed_data">Input argument #13</param>
    /// <param name="hours">Input argument #14</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] nsga_2(int numArgsOut, Object pop, Object gen, Object density0, 
                     Object input_flow, Object exit_density1, Object exit_ratio1, Object 
                     enter_flow1, Object enter_ratio1, Object enter_flow2, Object 
                     enter_ratio2, Object output_density, Object flow_data, Object 
                     speed_data, Object hours)
    {
      return mcr.EvaluateFunction(numArgsOut, "nsga_2", pop, gen, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data, speed_data, hours);
    }


    /// <summary>
    /// Provides the standard 15-input Object interface to the nsga_2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="pop">Input argument #1</param>
    /// <param name="gen">Input argument #2</param>
    /// <param name="density0">Input argument #3</param>
    /// <param name="input_flow">Input argument #4</param>
    /// <param name="exit_density1">Input argument #5</param>
    /// <param name="exit_ratio1">Input argument #6</param>
    /// <param name="enter_flow1">Input argument #7</param>
    /// <param name="enter_ratio1">Input argument #8</param>
    /// <param name="enter_flow2">Input argument #9</param>
    /// <param name="enter_ratio2">Input argument #10</param>
    /// <param name="output_density">Input argument #11</param>
    /// <param name="flow_data">Input argument #12</param>
    /// <param name="speed_data">Input argument #13</param>
    /// <param name="hours">Input argument #14</param>
    /// <param name="varargin">Array of Objects representing the input arguments 15
    /// through varargin.length+14</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] nsga_2(int numArgsOut, Object pop, Object gen, Object density0, 
                     Object input_flow, Object exit_density1, Object exit_ratio1, Object 
                     enter_flow1, Object enter_ratio1, Object enter_flow2, Object 
                     enter_ratio2, Object output_density, Object flow_data, Object 
                     speed_data, Object hours, params Object[] varargin)
    {
      Object[] argsIn= {pop, gen, density0, input_flow, exit_density1, exit_ratio1, enter_flow1, enter_ratio1, enter_flow2, enter_ratio2, output_density, flow_data, speed_data, hours, varargin};

      return mcr.EvaluateFunction(numArgsOut, "nsga_2", argsIn);
    }


    /// <summary>
    /// Provides an interface for the nsga_2 function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// function nsga_2(pop,gen)
    /// is a multi-objective optimization function where the input arguments are 
    /// pop - Population size
    /// gen - Total number of generations
    /// This functions is based on evolutionary algorithm for finding the optimal
    /// solution for multiple objective i.e. pareto front for the objectives. 
    /// Initially enter only the population size and the stoping criteria or
    /// the total number of generations after which the algorithm will
    /// automatically stopped. 
    /// You will be asked to enter the number of objective functions, the number
    /// of decision variables and the range space for the decision variables.
    /// Also you will have to define your own objective funciton by editing the
    /// evaluate_objective() function. A sample objective function is described
    /// in evaluate_objective.m. Kindly make sure that the objective function
    /// which you define match the number of objectives that you have entered as
    /// well as the number of decision variables that you have entered. The
    /// decision variable space is continuous for this function, but the
    /// objective space may or may not be continuous.
    /// Original algorithm NSGA-II was developed by researchers in Kanpur Genetic
    /// Algorithm Labarotary and kindly visit their website for more information
    /// http://www.iitk.ac.in/kangal/
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("nsga_2", 14, 1, 1)]
    protected void nsga_2(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("nsga_2", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the
    /// objective_description_function MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function [number_of_objectives, number_of_decision_variables,
    /// min_range_of_decesion_variable, max_range_of_decesion_variable] =
    /// objective_description_function()
    /// This function is used to completely describe the objective functions and
    /// the range for the decision variable space etc. The user is prompted for
    /// inputing the number of objectives, numebr of decision variables, the
    /// maximum and minimum range for each decision variable and finally the
    /// function waits for the user to modify the evaluate_objective function to
    /// suit their need.
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object objective_description_function()
    {
      return mcr.EvaluateFunction("objective_description_function", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the
    /// objective_description_function MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function [number_of_objectives, number_of_decision_variables,
    /// min_range_of_decesion_variable, max_range_of_decesion_variable] =
    /// objective_description_function()
    /// This function is used to completely describe the objective functions and
    /// the range for the decision variable space etc. The user is prompted for
    /// inputing the number of objectives, numebr of decision variables, the
    /// maximum and minimum range for each decision variable and finally the
    /// function waits for the user to modify the evaluate_objective function to
    /// suit their need.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] objective_description_function(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "objective_description_function", new Object[]{});
    }


    /// <summary>
    /// Provides an interface for the objective_description_function function in which
    /// the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// function [number_of_objectives, number_of_decision_variables,
    /// min_range_of_decesion_variable, max_range_of_decesion_variable] =
    /// objective_description_function()
    /// This function is used to completely describe the objective functions and
    /// the range for the decision variable space etc. The user is prompted for
    /// inputing the number of objectives, numebr of decision variables, the
    /// maximum and minimum range for each decision variable and finally the
    /// function waits for the user to modify the evaluate_objective function to
    /// suit their need.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("objective_description_function", 0, 4, 0)]
    protected void objective_description_function(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("objective_description_function", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PI()
    {
      return mcr.EvaluateFunction("PI", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PI(Object x)
    {
      return mcr.EvaluateFunction("PI", x);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="density0">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PI(Object x, Object density0)
    {
      return mcr.EvaluateFunction("PI", x, density0);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="density0">Input argument #2</param>
    /// <param name="input0">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PI(Object x, Object density0, Object input0)
    {
      return mcr.EvaluateFunction("PI", x, density0, input0);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="density0">Input argument #2</param>
    /// <param name="input0">Input argument #3</param>
    /// <param name="exitdensity1">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PI(Object x, Object density0, Object input0, Object exitdensity1)
    {
      return mcr.EvaluateFunction("PI", x, density0, input0, exitdensity1);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="density0">Input argument #2</param>
    /// <param name="input0">Input argument #3</param>
    /// <param name="exitdensity1">Input argument #4</param>
    /// <param name="exitratio1">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PI(Object x, Object density0, Object input0, Object exitdensity1, 
               Object exitratio1)
    {
      return mcr.EvaluateFunction("PI", x, density0, input0, exitdensity1, exitratio1);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="density0">Input argument #2</param>
    /// <param name="input0">Input argument #3</param>
    /// <param name="exitdensity1">Input argument #4</param>
    /// <param name="exitratio1">Input argument #5</param>
    /// <param name="enterflow1">Input argument #6</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PI(Object x, Object density0, Object input0, Object exitdensity1, 
               Object exitratio1, Object enterflow1)
    {
      return mcr.EvaluateFunction("PI", x, density0, input0, exitdensity1, exitratio1, enterflow1);
    }


    /// <summary>
    /// Provides a single output, 7-input Objectinterface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="density0">Input argument #2</param>
    /// <param name="input0">Input argument #3</param>
    /// <param name="exitdensity1">Input argument #4</param>
    /// <param name="exitratio1">Input argument #5</param>
    /// <param name="enterflow1">Input argument #6</param>
    /// <param name="enterratio1">Input argument #7</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PI(Object x, Object density0, Object input0, Object exitdensity1, 
               Object exitratio1, Object enterflow1, Object enterratio1)
    {
      return mcr.EvaluateFunction("PI", x, density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1);
    }


    /// <summary>
    /// Provides a single output, 8-input Objectinterface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="density0">Input argument #2</param>
    /// <param name="input0">Input argument #3</param>
    /// <param name="exitdensity1">Input argument #4</param>
    /// <param name="exitratio1">Input argument #5</param>
    /// <param name="enterflow1">Input argument #6</param>
    /// <param name="enterratio1">Input argument #7</param>
    /// <param name="enterflow2">Input argument #8</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PI(Object x, Object density0, Object input0, Object exitdensity1, 
               Object exitratio1, Object enterflow1, Object enterratio1, Object 
               enterflow2)
    {
      return mcr.EvaluateFunction("PI", x, density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2);
    }


    /// <summary>
    /// Provides a single output, 9-input Objectinterface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="density0">Input argument #2</param>
    /// <param name="input0">Input argument #3</param>
    /// <param name="exitdensity1">Input argument #4</param>
    /// <param name="exitratio1">Input argument #5</param>
    /// <param name="enterflow1">Input argument #6</param>
    /// <param name="enterratio1">Input argument #7</param>
    /// <param name="enterflow2">Input argument #8</param>
    /// <param name="enterratio2">Input argument #9</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PI(Object x, Object density0, Object input0, Object exitdensity1, 
               Object exitratio1, Object enterflow1, Object enterratio1, Object 
               enterflow2, Object enterratio2)
    {
      return mcr.EvaluateFunction("PI", x, density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2);
    }


    /// <summary>
    /// Provides a single output, 10-input Objectinterface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="density0">Input argument #2</param>
    /// <param name="input0">Input argument #3</param>
    /// <param name="exitdensity1">Input argument #4</param>
    /// <param name="exitratio1">Input argument #5</param>
    /// <param name="enterflow1">Input argument #6</param>
    /// <param name="enterratio1">Input argument #7</param>
    /// <param name="enterflow2">Input argument #8</param>
    /// <param name="enterratio2">Input argument #9</param>
    /// <param name="output">Input argument #10</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PI(Object x, Object density0, Object input0, Object exitdensity1, 
               Object exitratio1, Object enterflow1, Object enterratio1, Object 
               enterflow2, Object enterratio2, Object output)
    {
      return mcr.EvaluateFunction("PI", x, density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output);
    }


    /// <summary>
    /// Provides a single output, 11-input Objectinterface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="density0">Input argument #2</param>
    /// <param name="input0">Input argument #3</param>
    /// <param name="exitdensity1">Input argument #4</param>
    /// <param name="exitratio1">Input argument #5</param>
    /// <param name="enterflow1">Input argument #6</param>
    /// <param name="enterratio1">Input argument #7</param>
    /// <param name="enterflow2">Input argument #8</param>
    /// <param name="enterratio2">Input argument #9</param>
    /// <param name="output">Input argument #10</param>
    /// <param name="flow_data">Input argument #11</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PI(Object x, Object density0, Object input0, Object exitdensity1, 
               Object exitratio1, Object enterflow1, Object enterratio1, Object 
               enterflow2, Object enterratio2, Object output, Object flow_data)
    {
      return mcr.EvaluateFunction("PI", x, density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, flow_data);
    }


    /// <summary>
    /// Provides a single output, 12-input Objectinterface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="density0">Input argument #2</param>
    /// <param name="input0">Input argument #3</param>
    /// <param name="exitdensity1">Input argument #4</param>
    /// <param name="exitratio1">Input argument #5</param>
    /// <param name="enterflow1">Input argument #6</param>
    /// <param name="enterratio1">Input argument #7</param>
    /// <param name="enterflow2">Input argument #8</param>
    /// <param name="enterratio2">Input argument #9</param>
    /// <param name="output">Input argument #10</param>
    /// <param name="flow_data">Input argument #11</param>
    /// <param name="speed_data">Input argument #12</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PI(Object x, Object density0, Object input0, Object exitdensity1, 
               Object exitratio1, Object enterflow1, Object enterratio1, Object 
               enterflow2, Object enterratio2, Object output, Object flow_data, Object 
               speed_data)
    {
      return mcr.EvaluateFunction("PI", x, density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, flow_data, speed_data);
    }


    /// <summary>
    /// Provides a single output, 13-input Objectinterface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="density0">Input argument #2</param>
    /// <param name="input0">Input argument #3</param>
    /// <param name="exitdensity1">Input argument #4</param>
    /// <param name="exitratio1">Input argument #5</param>
    /// <param name="enterflow1">Input argument #6</param>
    /// <param name="enterratio1">Input argument #7</param>
    /// <param name="enterflow2">Input argument #8</param>
    /// <param name="enterratio2">Input argument #9</param>
    /// <param name="output">Input argument #10</param>
    /// <param name="flow_data">Input argument #11</param>
    /// <param name="speed_data">Input argument #12</param>
    /// <param name="hours">Input argument #13</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PI(Object x, Object density0, Object input0, Object exitdensity1, 
               Object exitratio1, Object enterflow1, Object enterratio1, Object 
               enterflow2, Object enterratio2, Object output, Object flow_data, Object 
               speed_data, Object hours)
    {
      return mcr.EvaluateFunction("PI", x, density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, flow_data, speed_data, hours);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PI(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "PI", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PI(int numArgsOut, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "PI", x);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="density0">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PI(int numArgsOut, Object x, Object density0)
    {
      return mcr.EvaluateFunction(numArgsOut, "PI", x, density0);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="density0">Input argument #2</param>
    /// <param name="input0">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PI(int numArgsOut, Object x, Object density0, Object input0)
    {
      return mcr.EvaluateFunction(numArgsOut, "PI", x, density0, input0);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="density0">Input argument #2</param>
    /// <param name="input0">Input argument #3</param>
    /// <param name="exitdensity1">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PI(int numArgsOut, Object x, Object density0, Object input0, Object 
                 exitdensity1)
    {
      return mcr.EvaluateFunction(numArgsOut, "PI", x, density0, input0, exitdensity1);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="density0">Input argument #2</param>
    /// <param name="input0">Input argument #3</param>
    /// <param name="exitdensity1">Input argument #4</param>
    /// <param name="exitratio1">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PI(int numArgsOut, Object x, Object density0, Object input0, Object 
                 exitdensity1, Object exitratio1)
    {
      return mcr.EvaluateFunction(numArgsOut, "PI", x, density0, input0, exitdensity1, exitratio1);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="density0">Input argument #2</param>
    /// <param name="input0">Input argument #3</param>
    /// <param name="exitdensity1">Input argument #4</param>
    /// <param name="exitratio1">Input argument #5</param>
    /// <param name="enterflow1">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PI(int numArgsOut, Object x, Object density0, Object input0, Object 
                 exitdensity1, Object exitratio1, Object enterflow1)
    {
      return mcr.EvaluateFunction(numArgsOut, "PI", x, density0, input0, exitdensity1, exitratio1, enterflow1);
    }


    /// <summary>
    /// Provides the standard 7-input Object interface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="density0">Input argument #2</param>
    /// <param name="input0">Input argument #3</param>
    /// <param name="exitdensity1">Input argument #4</param>
    /// <param name="exitratio1">Input argument #5</param>
    /// <param name="enterflow1">Input argument #6</param>
    /// <param name="enterratio1">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PI(int numArgsOut, Object x, Object density0, Object input0, Object 
                 exitdensity1, Object exitratio1, Object enterflow1, Object enterratio1)
    {
      return mcr.EvaluateFunction(numArgsOut, "PI", x, density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1);
    }


    /// <summary>
    /// Provides the standard 8-input Object interface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="density0">Input argument #2</param>
    /// <param name="input0">Input argument #3</param>
    /// <param name="exitdensity1">Input argument #4</param>
    /// <param name="exitratio1">Input argument #5</param>
    /// <param name="enterflow1">Input argument #6</param>
    /// <param name="enterratio1">Input argument #7</param>
    /// <param name="enterflow2">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PI(int numArgsOut, Object x, Object density0, Object input0, Object 
                 exitdensity1, Object exitratio1, Object enterflow1, Object enterratio1, 
                 Object enterflow2)
    {
      return mcr.EvaluateFunction(numArgsOut, "PI", x, density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2);
    }


    /// <summary>
    /// Provides the standard 9-input Object interface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="density0">Input argument #2</param>
    /// <param name="input0">Input argument #3</param>
    /// <param name="exitdensity1">Input argument #4</param>
    /// <param name="exitratio1">Input argument #5</param>
    /// <param name="enterflow1">Input argument #6</param>
    /// <param name="enterratio1">Input argument #7</param>
    /// <param name="enterflow2">Input argument #8</param>
    /// <param name="enterratio2">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PI(int numArgsOut, Object x, Object density0, Object input0, Object 
                 exitdensity1, Object exitratio1, Object enterflow1, Object enterratio1, 
                 Object enterflow2, Object enterratio2)
    {
      return mcr.EvaluateFunction(numArgsOut, "PI", x, density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2);
    }


    /// <summary>
    /// Provides the standard 10-input Object interface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="density0">Input argument #2</param>
    /// <param name="input0">Input argument #3</param>
    /// <param name="exitdensity1">Input argument #4</param>
    /// <param name="exitratio1">Input argument #5</param>
    /// <param name="enterflow1">Input argument #6</param>
    /// <param name="enterratio1">Input argument #7</param>
    /// <param name="enterflow2">Input argument #8</param>
    /// <param name="enterratio2">Input argument #9</param>
    /// <param name="output">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PI(int numArgsOut, Object x, Object density0, Object input0, Object 
                 exitdensity1, Object exitratio1, Object enterflow1, Object enterratio1, 
                 Object enterflow2, Object enterratio2, Object output)
    {
      return mcr.EvaluateFunction(numArgsOut, "PI", x, density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output);
    }


    /// <summary>
    /// Provides the standard 11-input Object interface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="density0">Input argument #2</param>
    /// <param name="input0">Input argument #3</param>
    /// <param name="exitdensity1">Input argument #4</param>
    /// <param name="exitratio1">Input argument #5</param>
    /// <param name="enterflow1">Input argument #6</param>
    /// <param name="enterratio1">Input argument #7</param>
    /// <param name="enterflow2">Input argument #8</param>
    /// <param name="enterratio2">Input argument #9</param>
    /// <param name="output">Input argument #10</param>
    /// <param name="flow_data">Input argument #11</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PI(int numArgsOut, Object x, Object density0, Object input0, Object 
                 exitdensity1, Object exitratio1, Object enterflow1, Object enterratio1, 
                 Object enterflow2, Object enterratio2, Object output, Object flow_data)
    {
      return mcr.EvaluateFunction(numArgsOut, "PI", x, density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, flow_data);
    }


    /// <summary>
    /// Provides the standard 12-input Object interface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="density0">Input argument #2</param>
    /// <param name="input0">Input argument #3</param>
    /// <param name="exitdensity1">Input argument #4</param>
    /// <param name="exitratio1">Input argument #5</param>
    /// <param name="enterflow1">Input argument #6</param>
    /// <param name="enterratio1">Input argument #7</param>
    /// <param name="enterflow2">Input argument #8</param>
    /// <param name="enterratio2">Input argument #9</param>
    /// <param name="output">Input argument #10</param>
    /// <param name="flow_data">Input argument #11</param>
    /// <param name="speed_data">Input argument #12</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PI(int numArgsOut, Object x, Object density0, Object input0, Object 
                 exitdensity1, Object exitratio1, Object enterflow1, Object enterratio1, 
                 Object enterflow2, Object enterratio2, Object output, Object flow_data, 
                 Object speed_data)
    {
      return mcr.EvaluateFunction(numArgsOut, "PI", x, density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, flow_data, speed_data);
    }


    /// <summary>
    /// Provides the standard 13-input Object interface to the PI MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="density0">Input argument #2</param>
    /// <param name="input0">Input argument #3</param>
    /// <param name="exitdensity1">Input argument #4</param>
    /// <param name="exitratio1">Input argument #5</param>
    /// <param name="enterflow1">Input argument #6</param>
    /// <param name="enterratio1">Input argument #7</param>
    /// <param name="enterflow2">Input argument #8</param>
    /// <param name="enterratio2">Input argument #9</param>
    /// <param name="output">Input argument #10</param>
    /// <param name="flow_data">Input argument #11</param>
    /// <param name="speed_data">Input argument #12</param>
    /// <param name="hours">Input argument #13</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PI(int numArgsOut, Object x, Object density0, Object input0, Object 
                 exitdensity1, Object exitratio1, Object enterflow1, Object enterratio1, 
                 Object enterflow2, Object enterratio2, Object output, Object flow_data, 
                 Object speed_data, Object hours)
    {
      return mcr.EvaluateFunction(numArgsOut, "PI", x, density0, input0, exitdensity1, exitratio1, enterflow1, enterratio1, enterflow2, enterratio2, output, flow_data, speed_data, hours);
    }


    /// <summary>
    /// Provides an interface for the PI function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// 对时间控制的简单判断 hours 表示仿真几小时的数据，
    /// 实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("PI", 13, 5, 0)]
    protected void PI(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("PI", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the replace_chromosome
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = replace_chromosome(intermediate_chromosome,pro,pop)
    /// This function replaces the chromosomes based on rank and crowding
    /// distance. Initially until the population size is reached each front is
    /// added one by one until addition of a complete front which results in
    /// exceeding the population size. At this point the chromosomes in that
    /// front is added subsequently to the population based on crowding distance.
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object replace_chromosome()
    {
      return mcr.EvaluateFunction("replace_chromosome", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the replace_chromosome
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = replace_chromosome(intermediate_chromosome,pro,pop)
    /// This function replaces the chromosomes based on rank and crowding
    /// distance. Initially until the population size is reached each front is
    /// added one by one until addition of a complete front which results in
    /// exceeding the population size. At this point the chromosomes in that
    /// front is added subsequently to the population based on crowding distance.
    /// </remarks>
    /// <param name="intermediate_chromosome">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object replace_chromosome(Object intermediate_chromosome)
    {
      return mcr.EvaluateFunction("replace_chromosome", intermediate_chromosome);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the replace_chromosome
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = replace_chromosome(intermediate_chromosome,pro,pop)
    /// This function replaces the chromosomes based on rank and crowding
    /// distance. Initially until the population size is reached each front is
    /// added one by one until addition of a complete front which results in
    /// exceeding the population size. At this point the chromosomes in that
    /// front is added subsequently to the population based on crowding distance.
    /// </remarks>
    /// <param name="intermediate_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object replace_chromosome(Object intermediate_chromosome, Object M)
    {
      return mcr.EvaluateFunction("replace_chromosome", intermediate_chromosome, M);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the replace_chromosome
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = replace_chromosome(intermediate_chromosome,pro,pop)
    /// This function replaces the chromosomes based on rank and crowding
    /// distance. Initially until the population size is reached each front is
    /// added one by one until addition of a complete front which results in
    /// exceeding the population size. At this point the chromosomes in that
    /// front is added subsequently to the population based on crowding distance.
    /// </remarks>
    /// <param name="intermediate_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object replace_chromosome(Object intermediate_chromosome, Object M, Object V)
    {
      return mcr.EvaluateFunction("replace_chromosome", intermediate_chromosome, M, V);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the replace_chromosome
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = replace_chromosome(intermediate_chromosome,pro,pop)
    /// This function replaces the chromosomes based on rank and crowding
    /// distance. Initially until the population size is reached each front is
    /// added one by one until addition of a complete front which results in
    /// exceeding the population size. At this point the chromosomes in that
    /// front is added subsequently to the population based on crowding distance.
    /// </remarks>
    /// <param name="intermediate_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="pop">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object replace_chromosome(Object intermediate_chromosome, Object M, Object V, 
                               Object pop)
    {
      return mcr.EvaluateFunction("replace_chromosome", intermediate_chromosome, M, V, pop);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the replace_chromosome MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = replace_chromosome(intermediate_chromosome,pro,pop)
    /// This function replaces the chromosomes based on rank and crowding
    /// distance. Initially until the population size is reached each front is
    /// added one by one until addition of a complete front which results in
    /// exceeding the population size. At this point the chromosomes in that
    /// front is added subsequently to the population based on crowding distance.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] replace_chromosome(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "replace_chromosome", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the replace_chromosome MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = replace_chromosome(intermediate_chromosome,pro,pop)
    /// This function replaces the chromosomes based on rank and crowding
    /// distance. Initially until the population size is reached each front is
    /// added one by one until addition of a complete front which results in
    /// exceeding the population size. At this point the chromosomes in that
    /// front is added subsequently to the population based on crowding distance.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="intermediate_chromosome">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] replace_chromosome(int numArgsOut, Object intermediate_chromosome)
    {
      return mcr.EvaluateFunction(numArgsOut, "replace_chromosome", intermediate_chromosome);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the replace_chromosome MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = replace_chromosome(intermediate_chromosome,pro,pop)
    /// This function replaces the chromosomes based on rank and crowding
    /// distance. Initially until the population size is reached each front is
    /// added one by one until addition of a complete front which results in
    /// exceeding the population size. At this point the chromosomes in that
    /// front is added subsequently to the population based on crowding distance.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="intermediate_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] replace_chromosome(int numArgsOut, Object intermediate_chromosome, 
                                 Object M)
    {
      return mcr.EvaluateFunction(numArgsOut, "replace_chromosome", intermediate_chromosome, M);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the replace_chromosome MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = replace_chromosome(intermediate_chromosome,pro,pop)
    /// This function replaces the chromosomes based on rank and crowding
    /// distance. Initially until the population size is reached each front is
    /// added one by one until addition of a complete front which results in
    /// exceeding the population size. At this point the chromosomes in that
    /// front is added subsequently to the population based on crowding distance.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="intermediate_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] replace_chromosome(int numArgsOut, Object intermediate_chromosome, 
                                 Object M, Object V)
    {
      return mcr.EvaluateFunction(numArgsOut, "replace_chromosome", intermediate_chromosome, M, V);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the replace_chromosome MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function f  = replace_chromosome(intermediate_chromosome,pro,pop)
    /// This function replaces the chromosomes based on rank and crowding
    /// distance. Initially until the population size is reached each front is
    /// added one by one until addition of a complete front which results in
    /// exceeding the population size. At this point the chromosomes in that
    /// front is added subsequently to the population based on crowding distance.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="intermediate_chromosome">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="pop">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] replace_chromosome(int numArgsOut, Object intermediate_chromosome, 
                                 Object M, Object V, Object pop)
    {
      return mcr.EvaluateFunction(numArgsOut, "replace_chromosome", intermediate_chromosome, M, V, pop);
    }


    /// <summary>
    /// Provides an interface for the replace_chromosome function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// function f  = replace_chromosome(intermediate_chromosome,pro,pop)
    /// This function replaces the chromosomes based on rank and crowding
    /// distance. Initially until the population size is reached each front is
    /// added one by one until addition of a complete front which results in
    /// exceeding the population size. At this point the chromosomes in that
    /// front is added subsequently to the population based on crowding distance.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("replace_chromosome", 4, 1, 0)]
    protected void replace_chromosome(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("replace_chromosome", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the standarization1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object standarization1()
    {
      return mcr.EvaluateFunction("standarization1", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the standarization1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="data">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object standarization1(Object data)
    {
      return mcr.EvaluateFunction("standarization1", data);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the standarization1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] standarization1(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "standarization1", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the standarization1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="data">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] standarization1(int numArgsOut, Object data)
    {
      return mcr.EvaluateFunction(numArgsOut, "standarization1", data);
    }


    /// <summary>
    /// Provides an interface for the standarization1 function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("standarization1", 1, 1, 0)]
    protected void standarization1(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("standarization1", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the topsis MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 染色体的7，8列为f1,f2，适应度，而topsis是根据这两个数值进行计算，选出最优的
    /// 核心思想： 求和-权重 * (实际值-理想值）^0.5 
    /// 其中权重为变异系数/总变异系数
    /// 其中变异系数为： 标准差/均值
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object topsis()
    {
      return mcr.EvaluateFunction("topsis", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the topsis MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 染色体的7，8列为f1,f2，适应度，而topsis是根据这两个数值进行计算，选出最优的
    /// 核心思想： 求和-权重 * (实际值-理想值）^0.5 
    /// 其中权重为变异系数/总变异系数
    /// 其中变异系数为： 标准差/均值
    /// </remarks>
    /// <param name="chromosome">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object topsis(Object chromosome)
    {
      return mcr.EvaluateFunction("topsis", chromosome);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the topsis MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 染色体的7，8列为f1,f2，适应度，而topsis是根据这两个数值进行计算，选出最优的
    /// 核心思想： 求和-权重 * (实际值-理想值）^0.5 
    /// 其中权重为变异系数/总变异系数
    /// 其中变异系数为： 标准差/均值
    /// </remarks>
    /// <param name="chromosome">Input argument #1</param>
    /// <param name="V">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object topsis(Object chromosome, Object V)
    {
      return mcr.EvaluateFunction("topsis", chromosome, V);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the topsis MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 染色体的7，8列为f1,f2，适应度，而topsis是根据这两个数值进行计算，选出最优的
    /// 核心思想： 求和-权重 * (实际值-理想值）^0.5 
    /// 其中权重为变异系数/总变异系数
    /// 其中变异系数为： 标准差/均值
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] topsis(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "topsis", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the topsis MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 染色体的7，8列为f1,f2，适应度，而topsis是根据这两个数值进行计算，选出最优的
    /// 核心思想： 求和-权重 * (实际值-理想值）^0.5 
    /// 其中权重为变异系数/总变异系数
    /// 其中变异系数为： 标准差/均值
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="chromosome">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] topsis(int numArgsOut, Object chromosome)
    {
      return mcr.EvaluateFunction(numArgsOut, "topsis", chromosome);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the topsis MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 染色体的7，8列为f1,f2，适应度，而topsis是根据这两个数值进行计算，选出最优的
    /// 核心思想： 求和-权重 * (实际值-理想值）^0.5 
    /// 其中权重为变异系数/总变异系数
    /// 其中变异系数为： 标准差/均值
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="chromosome">Input argument #1</param>
    /// <param name="V">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] topsis(int numArgsOut, Object chromosome, Object V)
    {
      return mcr.EvaluateFunction(numArgsOut, "topsis", chromosome, V);
    }


    /// <summary>
    /// Provides an interface for the topsis function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// 染色体的7，8列为f1,f2，适应度，而topsis是根据这两个数值进行计算，选出最优的
    /// 核心思想： 求和-权重 * (实际值-理想值）^0.5 
    /// 其中权重为变异系数/总变异系数
    /// 其中变异系数为： 标准差/均值
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("topsis", 2, 1, 0)]
    protected void topsis(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("topsis", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the tournament_selection
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function tournament_selection(chromosome, pool_size, tour_size) 
    /// is the selection policy for selecting the individuals for the mating 
    /// pool. The selection is based on tournament selection. Argument 
    /// |chromosome| is the current generation population from which the 
    /// individuals are selected to form a mating pool of size |pool_size| after 
    /// performing tournament selection, with size of the tournament being 
    /// |tour_size|. By varying the tournament size the selection pressure can be
    /// adjusted. But for NSGA-II the tour_size is fixed to two, but the user may
    /// feel free to experiment with different tournament size. Also it has been
    /// observed that a tournament size of more than five has no significant
    /// meaning. 
    /// Tournament selection process
    /// In a tournament selection process n individuals are selected at random,
    /// where n is equal to |tour_size|. From these individuals only one is selected
    /// and is added to the mating pool, where size of the mating pool is
    /// |pool_size|. Selection is performed based on two criteria. First and
    /// foremost is the rank or the front in which the solutions reside.
    /// Individuals with lower rank are selected. Secondly if the rank of two
    /// individuals are the same then, the crowding distance is compared.
    /// Individuals with greater crowding distance is selcted. 
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object tournament_selection()
    {
      return mcr.EvaluateFunction("tournament_selection", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the tournament_selection
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function tournament_selection(chromosome, pool_size, tour_size) 
    /// is the selection policy for selecting the individuals for the mating 
    /// pool. The selection is based on tournament selection. Argument 
    /// |chromosome| is the current generation population from which the 
    /// individuals are selected to form a mating pool of size |pool_size| after 
    /// performing tournament selection, with size of the tournament being 
    /// |tour_size|. By varying the tournament size the selection pressure can be
    /// adjusted. But for NSGA-II the tour_size is fixed to two, but the user may
    /// feel free to experiment with different tournament size. Also it has been
    /// observed that a tournament size of more than five has no significant
    /// meaning. 
    /// Tournament selection process
    /// In a tournament selection process n individuals are selected at random,
    /// where n is equal to |tour_size|. From these individuals only one is selected
    /// and is added to the mating pool, where size of the mating pool is
    /// |pool_size|. Selection is performed based on two criteria. First and
    /// foremost is the rank or the front in which the solutions reside.
    /// Individuals with lower rank are selected. Secondly if the rank of two
    /// individuals are the same then, the crowding distance is compared.
    /// Individuals with greater crowding distance is selcted. 
    /// </remarks>
    /// <param name="chromosome">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object tournament_selection(Object chromosome)
    {
      return mcr.EvaluateFunction("tournament_selection", chromosome);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the tournament_selection
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function tournament_selection(chromosome, pool_size, tour_size) 
    /// is the selection policy for selecting the individuals for the mating 
    /// pool. The selection is based on tournament selection. Argument 
    /// |chromosome| is the current generation population from which the 
    /// individuals are selected to form a mating pool of size |pool_size| after 
    /// performing tournament selection, with size of the tournament being 
    /// |tour_size|. By varying the tournament size the selection pressure can be
    /// adjusted. But for NSGA-II the tour_size is fixed to two, but the user may
    /// feel free to experiment with different tournament size. Also it has been
    /// observed that a tournament size of more than five has no significant
    /// meaning. 
    /// Tournament selection process
    /// In a tournament selection process n individuals are selected at random,
    /// where n is equal to |tour_size|. From these individuals only one is selected
    /// and is added to the mating pool, where size of the mating pool is
    /// |pool_size|. Selection is performed based on two criteria. First and
    /// foremost is the rank or the front in which the solutions reside.
    /// Individuals with lower rank are selected. Secondly if the rank of two
    /// individuals are the same then, the crowding distance is compared.
    /// Individuals with greater crowding distance is selcted. 
    /// </remarks>
    /// <param name="chromosome">Input argument #1</param>
    /// <param name="pool_size">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object tournament_selection(Object chromosome, Object pool_size)
    {
      return mcr.EvaluateFunction("tournament_selection", chromosome, pool_size);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the tournament_selection
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function tournament_selection(chromosome, pool_size, tour_size) 
    /// is the selection policy for selecting the individuals for the mating 
    /// pool. The selection is based on tournament selection. Argument 
    /// |chromosome| is the current generation population from which the 
    /// individuals are selected to form a mating pool of size |pool_size| after 
    /// performing tournament selection, with size of the tournament being 
    /// |tour_size|. By varying the tournament size the selection pressure can be
    /// adjusted. But for NSGA-II the tour_size is fixed to two, but the user may
    /// feel free to experiment with different tournament size. Also it has been
    /// observed that a tournament size of more than five has no significant
    /// meaning. 
    /// Tournament selection process
    /// In a tournament selection process n individuals are selected at random,
    /// where n is equal to |tour_size|. From these individuals only one is selected
    /// and is added to the mating pool, where size of the mating pool is
    /// |pool_size|. Selection is performed based on two criteria. First and
    /// foremost is the rank or the front in which the solutions reside.
    /// Individuals with lower rank are selected. Secondly if the rank of two
    /// individuals are the same then, the crowding distance is compared.
    /// Individuals with greater crowding distance is selcted. 
    /// </remarks>
    /// <param name="chromosome">Input argument #1</param>
    /// <param name="pool_size">Input argument #2</param>
    /// <param name="tour_size">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object tournament_selection(Object chromosome, Object pool_size, Object 
                                 tour_size)
    {
      return mcr.EvaluateFunction("tournament_selection", chromosome, pool_size, tour_size);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the tournament_selection MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function tournament_selection(chromosome, pool_size, tour_size) 
    /// is the selection policy for selecting the individuals for the mating 
    /// pool. The selection is based on tournament selection. Argument 
    /// |chromosome| is the current generation population from which the 
    /// individuals are selected to form a mating pool of size |pool_size| after 
    /// performing tournament selection, with size of the tournament being 
    /// |tour_size|. By varying the tournament size the selection pressure can be
    /// adjusted. But for NSGA-II the tour_size is fixed to two, but the user may
    /// feel free to experiment with different tournament size. Also it has been
    /// observed that a tournament size of more than five has no significant
    /// meaning. 
    /// Tournament selection process
    /// In a tournament selection process n individuals are selected at random,
    /// where n is equal to |tour_size|. From these individuals only one is selected
    /// and is added to the mating pool, where size of the mating pool is
    /// |pool_size|. Selection is performed based on two criteria. First and
    /// foremost is the rank or the front in which the solutions reside.
    /// Individuals with lower rank are selected. Secondly if the rank of two
    /// individuals are the same then, the crowding distance is compared.
    /// Individuals with greater crowding distance is selcted. 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] tournament_selection(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "tournament_selection", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the tournament_selection MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function tournament_selection(chromosome, pool_size, tour_size) 
    /// is the selection policy for selecting the individuals for the mating 
    /// pool. The selection is based on tournament selection. Argument 
    /// |chromosome| is the current generation population from which the 
    /// individuals are selected to form a mating pool of size |pool_size| after 
    /// performing tournament selection, with size of the tournament being 
    /// |tour_size|. By varying the tournament size the selection pressure can be
    /// adjusted. But for NSGA-II the tour_size is fixed to two, but the user may
    /// feel free to experiment with different tournament size. Also it has been
    /// observed that a tournament size of more than five has no significant
    /// meaning. 
    /// Tournament selection process
    /// In a tournament selection process n individuals are selected at random,
    /// where n is equal to |tour_size|. From these individuals only one is selected
    /// and is added to the mating pool, where size of the mating pool is
    /// |pool_size|. Selection is performed based on two criteria. First and
    /// foremost is the rank or the front in which the solutions reside.
    /// Individuals with lower rank are selected. Secondly if the rank of two
    /// individuals are the same then, the crowding distance is compared.
    /// Individuals with greater crowding distance is selcted. 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="chromosome">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] tournament_selection(int numArgsOut, Object chromosome)
    {
      return mcr.EvaluateFunction(numArgsOut, "tournament_selection", chromosome);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the tournament_selection MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function tournament_selection(chromosome, pool_size, tour_size) 
    /// is the selection policy for selecting the individuals for the mating 
    /// pool. The selection is based on tournament selection. Argument 
    /// |chromosome| is the current generation population from which the 
    /// individuals are selected to form a mating pool of size |pool_size| after 
    /// performing tournament selection, with size of the tournament being 
    /// |tour_size|. By varying the tournament size the selection pressure can be
    /// adjusted. But for NSGA-II the tour_size is fixed to two, but the user may
    /// feel free to experiment with different tournament size. Also it has been
    /// observed that a tournament size of more than five has no significant
    /// meaning. 
    /// Tournament selection process
    /// In a tournament selection process n individuals are selected at random,
    /// where n is equal to |tour_size|. From these individuals only one is selected
    /// and is added to the mating pool, where size of the mating pool is
    /// |pool_size|. Selection is performed based on two criteria. First and
    /// foremost is the rank or the front in which the solutions reside.
    /// Individuals with lower rank are selected. Secondly if the rank of two
    /// individuals are the same then, the crowding distance is compared.
    /// Individuals with greater crowding distance is selcted. 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="chromosome">Input argument #1</param>
    /// <param name="pool_size">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] tournament_selection(int numArgsOut, Object chromosome, Object 
                                   pool_size)
    {
      return mcr.EvaluateFunction(numArgsOut, "tournament_selection", chromosome, pool_size);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the tournament_selection MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// function tournament_selection(chromosome, pool_size, tour_size) 
    /// is the selection policy for selecting the individuals for the mating 
    /// pool. The selection is based on tournament selection. Argument 
    /// |chromosome| is the current generation population from which the 
    /// individuals are selected to form a mating pool of size |pool_size| after 
    /// performing tournament selection, with size of the tournament being 
    /// |tour_size|. By varying the tournament size the selection pressure can be
    /// adjusted. But for NSGA-II the tour_size is fixed to two, but the user may
    /// feel free to experiment with different tournament size. Also it has been
    /// observed that a tournament size of more than five has no significant
    /// meaning. 
    /// Tournament selection process
    /// In a tournament selection process n individuals are selected at random,
    /// where n is equal to |tour_size|. From these individuals only one is selected
    /// and is added to the mating pool, where size of the mating pool is
    /// |pool_size|. Selection is performed based on two criteria. First and
    /// foremost is the rank or the front in which the solutions reside.
    /// Individuals with lower rank are selected. Secondly if the rank of two
    /// individuals are the same then, the crowding distance is compared.
    /// Individuals with greater crowding distance is selcted. 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="chromosome">Input argument #1</param>
    /// <param name="pool_size">Input argument #2</param>
    /// <param name="tour_size">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] tournament_selection(int numArgsOut, Object chromosome, Object 
                                   pool_size, Object tour_size)
    {
      return mcr.EvaluateFunction(numArgsOut, "tournament_selection", chromosome, pool_size, tour_size);
    }


    /// <summary>
    /// Provides an interface for the tournament_selection function in which the input
    /// and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// function tournament_selection(chromosome, pool_size, tour_size) 
    /// is the selection policy for selecting the individuals for the mating 
    /// pool. The selection is based on tournament selection. Argument 
    /// |chromosome| is the current generation population from which the 
    /// individuals are selected to form a mating pool of size |pool_size| after 
    /// performing tournament selection, with size of the tournament being 
    /// |tour_size|. By varying the tournament size the selection pressure can be
    /// adjusted. But for NSGA-II the tour_size is fixed to two, but the user may
    /// feel free to experiment with different tournament size. Also it has been
    /// observed that a tournament size of more than five has no significant
    /// meaning. 
    /// Tournament selection process
    /// In a tournament selection process n individuals are selected at random,
    /// where n is equal to |tour_size|. From these individuals only one is selected
    /// and is added to the mating pool, where size of the mating pool is
    /// |pool_size|. Selection is performed based on two criteria. First and
    /// foremost is the rank or the front in which the solutions reside.
    /// Individuals with lower rank are selected. Secondly if the rank of two
    /// individuals are the same then, the crowding distance is compared.
    /// Individuals with greater crowding distance is selcted. 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("tournament_selection", 3, 1, 0)]
    protected void tournament_selection(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("tournament_selection", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }

    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private static Exception ex_= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
