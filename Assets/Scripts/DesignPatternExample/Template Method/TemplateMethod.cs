using UnityEngine;
using System.Collections;

namespace DesignPattern_TemplateMethod
{
	public abstract class Template
	{
		public void TemplateMethod()
		{
			StepOne();
			StepTwo();
			StepThree();
		}
		protected abstract void StepOne();
		protected abstract void StepTwo();
		protected abstract void StepThree();
	}

	public class ConcreteTemplate : Template
	{
		protected override void StepOne()
		{
			Debug.Log($"{nameof(StepOne)}:打开冰箱门");
		}

        protected override void StepTwo()
		{
			Debug.Log($"{nameof(StepOne)}:大象塞进去");
		}

		protected override void StepThree()
		{
			Debug.Log($"{nameof(StepOne)}:冰箱门关上");
		}
	}
		
}
