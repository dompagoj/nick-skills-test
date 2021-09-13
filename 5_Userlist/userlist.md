# React

`handleUserSelection = (userId) => { 
  this.setState({userId}); getUserDetails(this.state.userId, this.handleUserDetailsResponse); 
}`

The bug here is in 
`getUserDetails(this.state.userId, this.handleUserDetailsResponse);` 
because the userId passed is taken from state which is not updated there since setState is asynchronous, should be: 
  `getUserDetails(userId, this.handleUserDetailsResponse);`

Also I'm not sure why userId is in state at all here, ideally we would just route to a different screen based on the 
userId and fetch the data there, but if we wanted to keep it in state the fix would be to call getUserDetails inside the
callback of setState which is executed once the state is actually set.

The best place to call getAllUsers would be in componentDidMount, but since this is 2021 and we're not using class components
anymore the actual answer is inside useEffect where the dependencies are an empty array (effectively the same as componentDidMount)
But even that is pretty bad, ideally we would have a custom hook for fetching data, something like useFetch(getUsers) which would return
an object with data and loading keys where initially data would be null and loading true, when the data is fetched component is rerendered 
(rerender login lives inside the hook, which is the important part). 


See **userlist.jsx** for my ideal implementation of this type of component
