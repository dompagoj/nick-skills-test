# JS

operatorsInfo is missing this, should be: **this.operatorsInfo[operatorId] = [...this.operatorsInfo[operatorId], userId];**

**...operatorsInfo[operatorId]** is invalid in case there's no operator with that id, should be safe guarded with || [] (or ?? [] in modern js)

See the implementation of **getNumberOfUsersPerOperator** in index.html
