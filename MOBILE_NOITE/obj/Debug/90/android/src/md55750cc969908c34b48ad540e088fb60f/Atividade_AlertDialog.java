package md55750cc969908c34b48ad540e088fb60f;


public class Atividade_AlertDialog
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("MOBILE_NOITE.Atividade_AlertDialog, MOBILE_NOITE", Atividade_AlertDialog.class, __md_methods);
	}


	public Atividade_AlertDialog ()
	{
		super ();
		if (getClass () == Atividade_AlertDialog.class)
			mono.android.TypeManager.Activate ("MOBILE_NOITE.Atividade_AlertDialog, MOBILE_NOITE", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
