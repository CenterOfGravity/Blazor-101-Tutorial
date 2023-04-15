using Microsoft.JSInterop;
using Project.Components;

namespace Project.States
{
    public class FirebaseAuthStates : IDisposable
    {
        #region Properties
        public string Name { get; set; } = string.Empty;
        #endregion

        private readonly IJSRuntime js;
        public FirebaseAuthStates(IJSRuntime _js)
        {
            js = _js;
        }

        public event Action? OnChange;
        private void NotifyStateChanged() => OnChange?.Invoke();

        #region OnAuthStateChangedCode
        private DotNetObjectReference<FirebaseAuthStates>? ObjRef;
        public async Task OnAuthStateChanged()
        {
            //OnAuthStateChangedCode-Start
                ObjRef = DotNetObjectReference.Create(this);
            //    Console.WriteLine("OnInitializedAsync :" + Name);
                await js.InvokeVoidAsync("OnAuthStateChanged", ObjRef);
            //OnAuthStateChangedCode-End
        }

        [JSInvokable("JSInvokableOnAuthStateChanged")]
        public void JSInvokableOnAuthStateChanged(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                Name = name;
                Console.WriteLine("JSInvokableOnAuthStateChanged :" + Name);
                NotifyStateChanged();
            }
        }
        #endregion OnAuthStateChangedInCode



        public void Dispose()
        {
            ObjRef?.Dispose();
        }
    }
}
